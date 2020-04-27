using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DWNavigationPane
{
    [TemplatePart(Name = "PART_HeaderButton", Type = typeof(Button))]
    public class NavigationPane : Control
    {
        #region Dependency Properties

        #region ExtensionScale Property

        [Category("Layout")]
        [Description("Gets or sets the ratio of the Width to the ExtendedWidth starting from the CompactWidth. This is animated internally by the control")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double ExtensionScale
        {
            get => (double)GetValue(ExtensionScaleProperty);
            internal set => SetValue(ExtensionScaleProperty, value);
        }

        protected static readonly DependencyProperty ExtensionScaleProperty = DependencyProperty.Register(
            name: "ExtensionScale",
            propertyType: typeof(double),
            ownerType: typeof(NavigationPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion ExtensionScale Property

        #region Header Property

        [Category("Common")]
        [Description("Gets or sets the content set on the header of the Pane")]
        public object Header
        {
            get => GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            name: "Header",
            propertyType: typeof(object),
            ownerType: typeof(NavigationPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default));

        #endregion Header Property

        #region HeaderIcon Property

        [Category("Common")]
        [Description("Gets or sets the icon of the header from the MahApps Metro IconPacks.\n\nUsage in XAML Example: {x:Static maicons:PackIconEvaIconsKind.Menu}")]
        public Enum HeaderIcon
        {
            get => (Enum)GetValue(HeaderIconProperty);
            set => SetValue(HeaderIconProperty, value);
        }

        public static readonly DependencyProperty HeaderIconProperty = DependencyProperty.Register(
            name: "HeaderIcon",
            propertyType: typeof(Enum),
            ownerType: typeof(NavigationPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(Enum)));

        #endregion HeaderIcon Property

        #endregion Dependency Properties

        #region Inheritable Dependency Properties

        #region IconSize Property

        [Category("Layout")]
        [Description("Gets or sets the size of the icons of the items in the Pane")]
        public double IconSize
        {
            get => GetIconSize(this);
            set => SetIconSize(this, value);
        }

        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.RegisterAttached(
            name: "IconSize",
            propertyType: typeof(double),
            ownerType: typeof(NavigationPane),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(double),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static double GetIconSize(DependencyObject target) => (double)target.GetValue(IconSizeProperty);

        public static void SetIconSize(DependencyObject target, double value) => target.SetValue(IconSizeProperty, value);

        #endregion IconSize Property

        #region IsExtended Property

        [Category("Layout")]
        [Description("Gets or sets whether the Pane is extended or not.")]
        public bool IsExtended
        {
            get => GetIsExtended(this);
            set => SetIsExtended(this, value);
        }

        public static readonly DependencyProperty IsExtendedProperty = DependencyProperty.RegisterAttached(
            name: "IsExtended",
            propertyType: typeof(bool),
            ownerType: typeof(NavigationPane),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(bool),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static bool GetIsExtended(DependencyObject target) => (bool)target.GetValue(IsExtendedProperty);

        public static void SetIsExtended(DependencyObject target, bool value) => target.SetValue(IsExtendedProperty, value);

        #endregion IsExtended Property

        #region CompactWidth Property

        [Category("Layout")]
        [Description("Gets or sets the size of the Pane when compact")]
        public double CompactWidth
        {
            get => GetCompactWidth(this);
            set => SetCompactWidth(this, value);
        }

        public static readonly DependencyProperty CompactWidthProperty = DependencyProperty.RegisterAttached(
            name: "CompactWidth",
            propertyType: typeof(double),
            ownerType: typeof(NavigationPane),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(double),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static double GetCompactWidth(DependencyObject target) => (double)target.GetValue(CompactWidthProperty);

        public static void SetCompactWidth(DependencyObject target, double value) => target.SetValue(CompactWidthProperty, value);

        #endregion CompactWidth Property

        #region ExtendedWidth Property

        [Category("Layout")]
        [Description("Gets or sets the size of the Pane when compact")]
        public double ExtendedWidth
        {
            get => GetExtendedWidth(this);
            set => SetExtendedWidth(this, value);
        }

        public static readonly DependencyProperty ExtendedWidthProperty = DependencyProperty.RegisterAttached(
            name: "ExtendedWidth",
            propertyType: typeof(double),
            ownerType: typeof(NavigationPane),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(double),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static double GetExtendedWidth(DependencyObject target) => (double)target.GetValue(ExtendedWidthProperty);

        public static void SetExtendedWidth(DependencyObject target, double value) => target.SetValue(ExtendedWidthProperty, value);

        #endregion ExtendedWidth Property

        #region BackgroundHover Property

        [Description("Gets or sets the background of the item when hovered over by the mouse")]
        public Brush BackgroundHover
        {
            get => GetBackgroundHover(this);
            set => SetBackgroundHover(this, value);
        }

        public static readonly DependencyProperty BackgroundHoverProperty = DependencyProperty.RegisterAttached(
            name: "BackgroundHover",
            propertyType: typeof(Brush),
            ownerType: typeof(NavigationPane),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(Brush),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetBackgroundHover(DependencyObject target) => (Brush)target.GetValue(BackgroundHoverProperty);

        public static void SetBackgroundHover(DependencyObject target, Brush value) => target.SetValue(BackgroundHoverProperty, value);

        #endregion BackgroundHover Property

        #region ForegroundHover Property

        [Description("Gets or sets the foreground of the item when hovered over by the mouse")]
        public Brush ForegroundHover
        {
            get => GetForegroundHover(this);
            set => SetForegroundHover(this, value);
        }

        public static readonly DependencyProperty ForegroundHoverProperty = DependencyProperty.RegisterAttached(
            name: "ForegroundHover",
            propertyType: typeof(Brush),
            ownerType: typeof(NavigationPane),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(Brush),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetForegroundHover(DependencyObject target) => (Brush)target.GetValue(ForegroundHoverProperty);

        public static void SetForegroundHover(DependencyObject target, Brush value) => target.SetValue(ForegroundHoverProperty, value);

        #endregion ForegroundHover Property

        #endregion Inheritable Dependency Properties

        #region Container Dependency Properties

        #region Main Menu Property

        [Description("Gets the main menu collection of the pane")]
        public PaneItemCollection MainMenu
        {
            get => (PaneItemCollection)GetValue(MainMenuProperty);
            set => SetValue(MainMenuProperty, value);
        }

        public static readonly DependencyProperty MainMenuProperty = DependencyProperty.Register(
            name: "MainMenu",
            propertyType: typeof(PaneItemCollection),
            ownerType: typeof(NavigationPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: new PaneItemCollection()));

        #endregion Main Menu Property

        #region Bottom Menu Property

        [Description("Gets the bottom menu collection for the pane")]
        public PaneItemCollection BottomMenu
        {
            get => (PaneItemCollection)GetValue(BottomMenuProperty);
            set => SetValue(BottomMenuProperty, value);
        }

        public static readonly DependencyProperty BottomMenuProperty = DependencyProperty.Register(
            name: "BottomMenu",
            propertyType: typeof(PaneItemCollection),
            ownerType: typeof(NavigationPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: new PaneItemCollection()));

        #endregion Bottom Menu Property

        #endregion Container Dependency Properties

        #region Event Handlers

        #region HeaderButton Action

        private void HeaderButton_Click(object sender, RoutedEventArgs e)
        {
            IsExtended = !IsExtended;
        }

        #endregion HeaderButton Action

        #endregion Event Handlers

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var headerButton = GetTemplateChild("PART_HeaderButton") as Button;
            if (headerButton == null)
                throw new NullReferenceException("Template part \"PART_HeaderButton\" not found");
            else
                headerButton.Click += HeaderButton_Click;
        }

        static NavigationPane()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(NavigationPane),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(NavigationPane)));
        }

        public NavigationPane()
        {
            MainMenu = new PaneItemCollection();
            BottomMenu = new PaneItemCollection();
        }
    }
}