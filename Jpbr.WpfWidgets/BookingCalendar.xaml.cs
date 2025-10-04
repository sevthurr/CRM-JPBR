using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Jpbr.WpfWidgets
{
    /// <summary>
    /// Interaction logic for BookingCalendar.xaml
    /// </summary>
    public partial class BookingCalendar : UserControl
    {
        // Current display date
        private DateTime _currentMonth;
        
        // Collection for binding to the calendar grid
        private ObservableCollection<CalendarDay> _days = new ObservableCollection<CalendarDay>();

        // Currently selected day for highlighting
        private Border _selectedDayBorder = null;
        private CalendarDay _selectedDay = null;
        
        // Status enums for days
        public enum DayStatus { Available, Booked, Closed, None }

        // Reference to UI elements
        private TextBlock _calendarHeader;
        private ItemsControl _calendarGrid;
        
        // Popup for closing dates
        private Popup _dateTogglePopup;
        private CheckBox _closeDateToggle;
        private DateTime _popupDate;

        // For demo, assume today is October 4, 2025
        private readonly DateTime _demoTodayDate = new DateTime(2025, 10, 4);

        public BookingCalendar()
        {
            InitializeComponent();
            
            // Register value converters
            this.Resources.Add("StatusToColorConverter", new StatusToColorConverter());
            this.Resources.Add("StatusToIndicatorConverter", new StatusToIndicatorConverter());
            this.Resources.Add("BooleanToVisibilityConverter", new BooleanToVisibilityConverter());

            // Find named elements after initialization
            _calendarHeader = this.FindName("CalendarHeader") as TextBlock;
            _calendarGrid = this.FindName("CalendarGrid") as ItemsControl;

            // Set current month to October 2025 for the demo
            _currentMonth = new DateTime(2025, 10, 1);
            
            // Create toggle popup for closing dates
            CreateTogglePopup();
            
            // Initialize calendar
            this.Loaded += (s, e) => {
                // Wait until loaded so layout is ready
                RenderCalendar();
            };

            // Handle size changes to maintain responsiveness
            this.SizeChanged += (s, e) => {
                if (e.WidthChanged || e.HeightChanged)
                {
                    // Recreate calendar cells when container size changes
                    if (_days.Count > 0)
                        CreateCalendarDays();
                }
            };
        }
        
        // Create the toggle popup for closing dates
        private void CreateTogglePopup()
        {
            // Create the popup
            _dateTogglePopup = new Popup
            {
                AllowsTransparency = true,
                Placement = PlacementMode.Mouse,
                StaysOpen = false,
                PopupAnimation = PopupAnimation.Fade
            };
            
            // Create the content border
            Border popupBorder = new Border
            {
                Background = Brushes.White,
                BorderBrush = new SolidColorBrush(Color.FromRgb(200, 200, 200)),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(10),
                Effect = new System.Windows.Media.Effects.DropShadowEffect
                {
                    Color = Colors.Gray,
                    BlurRadius = 4,
                    ShadowDepth = 2,
                    Opacity = 0.3
                }
            };
            
            // Create content grid
            Grid popupGrid = new Grid();
            popupGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            popupGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            
            // Add label
            TextBlock label = new TextBlock
            {
                Text = "Close date",
                VerticalAlignment = VerticalAlignment.Center,
                FontFamily = new FontFamily("Poppins"),
                FontSize = 14,
                Margin = new Thickness(0, 0, 10, 0),
                Foreground = new SolidColorBrush(Color.FromRgb(80, 80, 80))
            };
            Grid.SetColumn(label, 0);
            
            // Create a styled toggle switch using a checkbox
            _closeDateToggle = new CheckBox
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Right,
                Style = (Style)this.Resources["ToggleSwitchStyle"]
            };
            _closeDateToggle.Checked += CloseDateToggle_Checked;
            _closeDateToggle.Unchecked += CloseDateToggle_Unchecked;
            Grid.SetColumn(_closeDateToggle, 1);
            
            // Add elements to grid
            popupGrid.Children.Add(label);
            popupGrid.Children.Add(_closeDateToggle);
            
            // Add grid to border
            popupBorder.Child = popupGrid;
            
            // Set popup content
            _dateTogglePopup.Child = popupBorder;
        }
        
        // Event handlers for toggle button
        private void CloseDateToggle_Checked(object sender, RoutedEventArgs e)
        {
            // Find the day for this date and update its status
            UpdateDateStatus(_popupDate, DayStatus.Closed);
        }
        
        private void CloseDateToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            // Find the day for this date and update its status
            UpdateDateStatus(_popupDate, DayStatus.Available);
        }
        
        // Update date status and refresh calendar
        private void UpdateDateStatus(DateTime date, DayStatus status)
        {
            // Find the day with matching date
            var day = _days.FirstOrDefault(d => d.Date.Date == date.Date);
            if (day != null)
            {
                day.Status = status;
                
                // Update the UI
                CreateCalendarDays();
                
                // Close popup
                _dateTogglePopup.IsOpen = false;
            }
        }
        
        // Refreshes the calendar UI
        private void RenderCalendar()
        {
            // Update header with month/year
            if (_calendarHeader != null)
                _calendarHeader.Text = _currentMonth.ToString("MMMM yyyy");
            
            // Clear existing days
            _days.Clear();
            
            // Get first day of month
            var firstDay = new DateTime(_currentMonth.Year, _currentMonth.Month, 1);
            
            // Get day of week (0 = Sunday, 6 = Saturday)
            int startOffset = (int)firstDay.DayOfWeek;
            
            // Get days in month
            int daysInMonth = DateTime.DaysInMonth(_currentMonth.Year, _currentMonth.Month);
            
            // Get previous month info for padding
            var previousMonth = _currentMonth.AddMonths(-1);
            int daysInPreviousMonth = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            
            // Add days from previous month (for padding)
            for (int i = 0; i < startOffset; i++)
            {
                int prevMonthDay = daysInPreviousMonth - startOffset + i + 1;
                _days.Add(new CalendarDay 
                { 
                    Day = prevMonthDay.ToString(), 
                    IsCurrentMonth = false,
                    Date = new DateTime(previousMonth.Year, previousMonth.Month, prevMonthDay),
                    IsPast = true
                });
            }
            
            // Add days for current month
            for (int i = 1; i <= daysInMonth; i++)
            {
                var currentDate = new DateTime(_currentMonth.Year, _currentMonth.Month, i);
                bool isPastDay = currentDate < _demoTodayDate;
                
                // Assign status
                var status = GetDemoStatusForDate(currentDate);
                
                _days.Add(new CalendarDay 
                { 
                    Day = i.ToString(),
                    IsCurrentMonth = true, 
                    Status = status,
                    HasStatus = !isPastDay, // Only future days have status
                    IsToday = currentDate.Date == _demoTodayDate.Date,
                    Date = currentDate,
                    IsPast = isPastDay
                });
            }
            
            // Add days from next month to fill the grid (6 rows x 7 days = 42 cells total)
            int remainingCells = 42 - startOffset - daysInMonth;
            var nextMonth = _currentMonth.AddMonths(1);
            
            for (int i = 1; i <= remainingCells; i++)
            {
                _days.Add(new CalendarDay 
                { 
                    Day = i.ToString(), 
                    IsCurrentMonth = false,
                    Date = new DateTime(nextMonth.Year, nextMonth.Month, i),
                    IsPast = false
                });
            }

            // Create calendar day controls
            CreateCalendarDays();
        }

        // For demo purposes only - assigns statuses to dates
        private DayStatus GetDemoStatusForDate(DateTime date)
        {
            // Fixed "demo" statuses for consistent appearance
            if (date.Day % 10 == 4 || date.Day % 10 == 5 || date.Day % 10 == 2 || date.Day == 28)
                return DayStatus.Closed;
            else if (date.Day % 10 == 7 || date.Day % 10 == 8 || date.Day % 10 == 9 || date.Day == 15 || date.Day == 16 || date.Day == 17)
                return DayStatus.Booked;
            else
                return DayStatus.Available; // All other days in current month are "available"
        }
        
        // Creates the visual elements for each day
        private void CreateCalendarDays()
        {
            if (_calendarGrid == null)
                return;
                
            // Clear existing calendar items
            _calendarGrid.Items.Clear();
            _selectedDayBorder = null;
            
            // Optimized cell size for perfect circles
            double cellSize = 52; 
            
            foreach (var day in _days)
            {
                // Create container for the day with optimal spacing
                Grid cellContainer = new Grid
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    Margin = new Thickness(2)
                };

                // Create day cell container
                Border cellBorder = new Border
                {
                    CornerRadius = new CornerRadius(cellSize/2),
                    Width = cellSize,
                    Height = cellSize,
                    Tag = day, // Store the day data in the Tag
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                // Create day content
                Grid dayGrid = new Grid();
                
                // Day background ellipse - only add for current month days that aren't past
                if (day.IsCurrentMonth && !day.IsPast)
                {
                    Ellipse background = new Ellipse
                    {
                        Width = cellSize,
                        Height = cellSize,
                        Fill = GetBrushForStatus(day)
                    };
                    dayGrid.Children.Add(background);
                }
                
                // Add blue circle border for today (October 4)
                if (day.IsToday)
                {
                    cellBorder.BorderBrush = new SolidColorBrush(Colors.DodgerBlue);
                    cellBorder.BorderThickness = new Thickness(2);
                }

                // Text and indicator - centered in the cell
                StackPanel contentPanel = new StackPanel
                {
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                
                TextBlock dayText = new TextBlock
                {
                    Text = day.Day,
                    FontFamily = new FontFamily("Poppins"),
                    FontWeight = day.IsCurrentMonth ? FontWeights.SemiBold : FontWeights.Regular,
                    FontSize = 14,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Foreground = GetTextColorForDay(day)
                };
                
                contentPanel.Children.Add(dayText);
                
                // Add status indicator if needed (use smaller dots)
                if (day.HasStatus && day.IsCurrentMonth && !day.IsPast && day.Status != DayStatus.Available)
                {
                    Ellipse statusDot = new Ellipse
                    {
                        Width = 5,
                        Height = 5,
                        Margin = new Thickness(0, 2, 0, 0),
                        Fill = GetIndicatorBrushForStatus(day.Status)
                    };
                    
                    contentPanel.Children.Add(statusDot);
                }
                
                // Add content panel to day grid
                dayGrid.Children.Add(contentPanel);
                
                // Add grid to cell border
                cellBorder.Child = dayGrid;
                
                // Add click behaviors - only allow for current/future days
                if (!day.IsPast)
                {
                    cellBorder.MouseDown += DayCell_MouseDown;
                    
                    // Add double-click handler for toggle popup
                    cellBorder.MouseLeftButtonDown += (s, e) => {
                        if (e.ClickCount == 2 && day.IsCurrentMonth)
                        {
                            ShowDateTogglePopup(s as Border, day);
                            e.Handled = true;
                        }
                    };
                }
                
                // Add to container and then to calendar
                cellContainer.Children.Add(cellBorder);
                _calendarGrid.Items.Add(cellContainer);

                // If it's day 4 (today), store as selected to match the reference
                if (day.IsToday)
                {
                    _selectedDayBorder = cellBorder;
                    _selectedDay = day;
                }
            }
        }
        
        // Show toggle popup when double-clicking a date
        private void ShowDateTogglePopup(Border cellBorder, CalendarDay day)
        {
            if (cellBorder == null || day == null || !day.IsCurrentMonth || day.IsPast)
                return;
            
            // Set the popup date
            _popupDate = day.Date;
            
            // Set toggle state based on current status
            _closeDateToggle.IsChecked = day.Status == DayStatus.Closed;
            
            // Position and show popup
            _dateTogglePopup.PlacementTarget = cellBorder;
            _dateTogglePopup.IsOpen = true;
        }

        // Get the appropriate text color based on day status
        private Brush GetTextColorForDay(CalendarDay day)
        {
            // Past days or non-current month days
            if (!day.IsCurrentMonth || day.IsPast)
                return new SolidColorBrush(Color.FromRgb(150, 150, 150)); // Light gray for past/non-current
            
            // Closed days should have grey text - NEW REQUIREMENT
            if (day.Status == DayStatus.Closed)
                return new SolidColorBrush(Color.FromRgb(120, 120, 120)); // Darker gray for closed dates
                
            // Selected day - use blue text
            if (day.IsToday)
                return new SolidColorBrush(Colors.Black); // Black text for today
                
            return Brushes.Black; // Black text for normal current/future days
        }

        // Event handler for day cell click
        private void DayCell_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Only handle single clicks, double clicks are handled separately
            if (e.ClickCount > 1)
                return;
                
            if (sender is Border clickedBorder && clickedBorder.Tag is CalendarDay clickedDay)
            {
                // Only allow clicking on current month days that aren't past
                if (!clickedDay.IsCurrentMonth || clickedDay.IsPast)
                    return;
                
                // Remove highlight from previously selected day
                if (_selectedDayBorder != null && _selectedDayBorder != clickedBorder)
                {
                    _selectedDayBorder.BorderBrush = null;
                    _selectedDayBorder.BorderThickness = new Thickness(0);
                    
                    // If it was "today", restore its blue border
                    if (_selectedDay != null && _selectedDay.IsToday)
                    {
                        _selectedDayBorder.BorderBrush = new SolidColorBrush(Colors.DodgerBlue);
                        _selectedDayBorder.BorderThickness = new Thickness(2);
                    }
                }
                
                // Highlight the clicked day
                if (clickedBorder != _selectedDayBorder)
                {
                    _selectedDayBorder = clickedBorder;
                    _selectedDay = clickedDay;
                    
                    // Apply blue border
                    clickedBorder.BorderBrush = new SolidColorBrush(Colors.DodgerBlue);
                    clickedBorder.BorderThickness = new Thickness(2);
                    
                    // You could raise an event here or call a method to inform the application about the selected date
                    Console.WriteLine($"Selected date: {clickedDay.Date.ToShortDateString()}");
                }
                else
                {
                    // If clicking on today, just keep the blue border
                    if (!clickedDay.IsToday)
                    {
                        _selectedDayBorder = null;
                        _selectedDay = null;
                    }
                }
            }
        }
        
        // Event handlers for navigation buttons
        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            _currentMonth = _currentMonth.AddMonths(-1);
            RenderCalendar();
        }
        
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            _currentMonth = _currentMonth.AddMonths(1);
            RenderCalendar();
        }
        
        // Helper method to get brush for day background based on status and current month
        private Brush GetBrushForStatus(CalendarDay day)
        {
            // Past days or non-current month days have no background
            if (!day.IsCurrentMonth || day.IsPast)
                return Brushes.Transparent;
                
            // For current and future month days
            switch (day.Status)
            {
                case DayStatus.Available:
                    return (SolidColorBrush)Resources["AvailableColor"];
                case DayStatus.Booked:
                    return (SolidColorBrush)Resources["AvailableColor"]; // Still yellow background
                case DayStatus.Closed:
                    return (SolidColorBrush)Resources["AvailableColor"]; // Still yellow background
                default:
                    return Brushes.Transparent;
            }
        }
        
        // Helper method to get brush for status indicators
        private Brush GetIndicatorBrushForStatus(DayStatus status)
        {
            switch (status)
            {
                case DayStatus.Booked:
                    return (SolidColorBrush)Resources["BookedColor"];
                case DayStatus.Closed:
                    return (SolidColorBrush)Resources["ClosedColor"];
                default:
                    return Brushes.Transparent;
            }
        }
    }
    
    // Calendar day data class
    public class CalendarDay
    {
        public string Day { get; set; }
        public bool IsCurrentMonth { get; set; }
        public bool IsToday { get; set; }
        public BookingCalendar.DayStatus Status { get; set; } = BookingCalendar.DayStatus.None;
        public bool HasStatus { get; set; }
        public DateTime Date { get; set; }
        public bool IsPast { get; set; } // New property to track past days
    }
    
    // Value converter for status to background color
    public class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BookingCalendar.DayStatus status)
            {
                switch (status)
                {
                    case BookingCalendar.DayStatus.Available:
                        return new SolidColorBrush(Color.FromRgb(248, 220, 149)); // Light yellow
                    default:
                        return Brushes.Transparent;
                }
            }
            return Brushes.Transparent;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    
    // Value converter for status to indicator color
    public class StatusToIndicatorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BookingCalendar.DayStatus status)
            {
                switch (status)
                {
                    case BookingCalendar.DayStatus.Booked:
                        return new SolidColorBrush(Color.FromRgb(60, 179, 113)); // Green
                    case BookingCalendar.DayStatus.Closed:
                        return new SolidColorBrush(Color.FromRgb(231, 76, 60)); // Red
                    default:
                        return Brushes.Transparent;
                }
            }
            return Brushes.Transparent;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    
    // Boolean to Visibility converter
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isVisible && isVisible)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
