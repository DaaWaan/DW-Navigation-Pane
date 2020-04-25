using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DWNavigationPane
{
    public class NavigationPaneItem : Button, INavigationPaneItem
    {
        #region Dependency Properties

        #region Icon Property

        [Category("Common")]
        [Description("Gets or sets the icon of the header from the MahApps Metro IconPacks.\n\nUsage in XAML Example: {x:Static maicons:PackIconEvaIconsKind.Menu}")]
        public Enum Icon
        {
            get => (Enum)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        protected static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            name: "Icon",
            propertyType: typeof(Enum),
            ownerType: typeof(NavigationPaneItem),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(Enum)));

        #endregion Icon Property

        #endregion Dependency Properties

        #region Inheritable Dependency Properties

        #region IconSize Property

        [Category("Layout")]
        [Description("Gets or sets the size of the icon of the Item")]
        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }

        protected static readonly DependencyProperty IconSizeProperty;

        #endregion IconSize Property

        #region IsExtended Property

        [Category("Layout")]
        [Description("Gets or sets whether the item is currently extended or not.")]
        public bool IsExtended
        {
            get => (bool)GetValue(IsExtendedProperty);
            set => SetValue(IsExtendedProperty, value);
        }

        public static readonly DependencyProperty IsExtendedProperty;

        #endregion IsExtended Property

        #region CompactWidth Property

        [Category("Layout")]
        [Description("Gets or sets the width of the Item when compact")]
        public double CompactWidth
        {
            get => (double)GetValue(CompactWidthProperty);
            set => SetValue(CompactWidthProperty, value);
        }

        protected static readonly DependencyProperty CompactWidthProperty;

        #endregion CompactWidth Property

        #region ExtendedWidth Property

        [Category("Layout")]
        [Description("Gets or sets the width of the Item when extended")]
        public double ExtendedWidth
        {
            get => (double)GetValue(ExtendedWidthProperty);
            set => SetValue(ExtendedWidthProperty, value);
        }

        protected static readonly DependencyProperty ExtendedWidthProperty;

        #endregion ExtendedWidth Property

        #region BackgroundHover Property

        [Description("Gets or sets the background of the item when hovered over by the mouse")]
        public Brush BackgroundHover
        {
            get => (Brush)GetValue(BackgroundHoverProperty) ?? (Brush)GetValue(BackgroundProperty);
            set => SetValue(BackgroundHoverProperty, value);
        }

        protected static readonly DependencyProperty BackgroundHoverProperty;

        #endregion BackgroundHover Property

        #region ForegroundHover Property

        [Description("Gets or sets the foreground of the item when hovered over by the mouse")]
        public Brush ForegroundHover
        {
            get => (Brush)GetValue(ForegroundHoverProperty) ?? (Brush)GetValue(ForegroundProperty);
            set => SetValue(ForegroundHoverProperty, value);
        }

        protected static readonly DependencyProperty ForegroundHoverProperty;

        #endregion ForegroundHover Property

        #endregion Inheritable Dependency Properties

        static NavigationPaneItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(NavigationPaneItem)));

            #region Initialization of Inheritable Dependency Properties

            IconSizeProperty = NavigationPane.IconSizeProperty.AddOwner(
                ownerType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: default(double),
                    flags: FrameworkPropertyMetadataOptions.Inherits));

            IsExtendedProperty = NavigationPane.IsExtendedProperty.AddOwner(
                ownerType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: default(bool),
                    flags: FrameworkPropertyMetadataOptions.Inherits));

            CompactWidthProperty = NavigationPane.CompactWidthProperty.AddOwner(
                ownerType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: default(double),
                    flags: FrameworkPropertyMetadataOptions.Inherits));

            ExtendedWidthProperty = NavigationPane.ExtendedWidthProperty.AddOwner(
                ownerType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: default(double),
                    flags: FrameworkPropertyMetadataOptions.Inherits));

            BackgroundHoverProperty = NavigationPane.BackgroundHoverProperty.AddOwner(
                ownerType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: default(Brush),
                    flags: FrameworkPropertyMetadataOptions.Inherits));

            ForegroundHoverProperty = NavigationPane.ForegroundHoverProperty.AddOwner(
                ownerType: typeof(NavigationPaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: default(Brush),
                    flags: FrameworkPropertyMetadataOptions.Inherits));

            #endregion Initialization of Inheritable Dependency Properties
        }
    }
}