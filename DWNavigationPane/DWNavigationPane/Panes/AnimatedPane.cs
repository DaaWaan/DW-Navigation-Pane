using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Animation;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides the basic properties for an animated Pane.
    /// </summary>
    public class AnimatedPane : StaticPane
    {
        #region RoutedEvent Properties

        #region PaneOpenedEvent

        /// <summary>
        /// Raised Event when the Pane is opened
        /// </summary>
        public static readonly RoutedEvent PaneOpenedEvent = EventManager.RegisterRoutedEvent(
            name: "PaneOpened",
            routingStrategy: RoutingStrategy.Bubble,
            handlerType: typeof(RoutedEventHandler),
            ownerType: typeof(AnimatedPane));

        public event RoutedEventHandler PaneOpened
        {
            add { AddHandler(PaneOpenedEvent, value); }
            remove { RemoveHandler(PaneOpenedEvent, value); }
        }

        #endregion PaneOpenedEvent

        #region PaneClosedEvent

        /// <summary>
        /// Raised Event when the Pane is closed
        /// </summary>
        public static readonly RoutedEvent PaneClosedEvent = EventManager.RegisterRoutedEvent(
            name: "PaneClosed",
            routingStrategy: RoutingStrategy.Bubble,
            handlerType: typeof(RoutedEventHandler),
            ownerType: typeof(AnimatedPane));

        public event RoutedEventHandler PaneClosed
        {
            add { AddHandler(PaneClosedEvent, value); }
            remove { RemoveHandler(PaneClosedEvent, value); }
        }

        #endregion PaneClosedEvent

        #endregion RoutedEvent Properties

        #region Dependency Properties

        #region IsTransformInverted Property

        /// <summary>
        /// Gets or sets whether the Pane transform progress is inverted.
        /// </summary>
        [Category("Common")]
        [Description("Gets or sets whether the Pane transform progress is inverted.")]
        public bool IsTransformInverted
        {
            get => (bool)GetValue(IsTransformInvertedProperty);
            set => SetValue(IsTransformInvertedProperty, value);
        }

        public static readonly DependencyProperty IsTransformInvertedProperty = DependencyProperty.Register(
            name: "IsTransformInverted",
            propertyType: typeof(bool),
            ownerType: typeof(AnimatedPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(bool)));

        #endregion IsTransformInverted Property

        #region OpenTransformAnimation Property

        /// <summary>
        /// Animates the TransformProgress Property from 0.0 to 1.0 when the Pane opens.
        /// </summary>
        [Category("Common")]
        [Description("Animates the TransformProgress Property from 0.0 to 1.0 when the Pane opens.")]
        public DoubleAnimation OpenTransformAnimation
        {
            get => (DoubleAnimation)GetValue(OpenTransformAnimationProperty);
            set => SetValue(OpenTransformAnimationProperty, value);
        }

        public static readonly DependencyProperty OpenTransformAnimationProperty = DependencyProperty.Register(
            name: "OpenTransformAnimation",
            propertyType: typeof(DoubleAnimation),
            ownerType: typeof(AnimatedPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: new DoubleAnimation(),
                propertyChangedCallback: OnTransformAnimationChanged));

        #endregion OpenTransformAnimation Property

        #region CloseTransformAnimation Property

        /// <summary>
        /// Animates the TransformProgress Property from 1.0 to 0.0 when the Pane opens.
        /// </summary>
        [Category("Common")]
        [Description("Animates the TransformProgress Property from 1.0 to 0.0 when the Pane opens.")]
        public DoubleAnimation CloseTransformAnimation
        {
            get => (DoubleAnimation)GetValue(CloseTransformAnimationProperty);
            set => SetValue(CloseTransformAnimationProperty, value);
        }

        public static readonly DependencyProperty CloseTransformAnimationProperty = DependencyProperty.Register(
            name: "CloseTransformAnimation",
            propertyType: typeof(DoubleAnimation),
            ownerType: typeof(AnimatedPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: new DoubleAnimation(),
                propertyChangedCallback: OnTransformAnimationChanged));

        #endregion CloseTransformAnimation Property

        #region OnTransformAnimationChanged Callback

        /// <summary>
        /// Freezes the new TransformAnimation.
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private static void OnTransformAnimationChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ((Freezable)sender.GetValue(e.Property)).Freeze();
        }

        #endregion OnTransformAnimationChanged Callback

        #region TransformedValue Property

        /// <summary>
        /// Gets the current resulting transformed value for the AnimatedPane.
        /// This is computed internally for inheriting Panes.
        /// </summary>
        [Category("Layout")]
        [Description("Gets the current resulting transformed value for the AnimatedPane. This is computed internally for inheriting Panes.")]
        public double TransformedValue
        {
            get => (double)GetValue(TransformedValueProperty);
            set => SetValue(TransformedValueProperty, value);
        }

        public static readonly DependencyProperty TransformedValueProperty = DependencyProperty.Register(
            name: "TransformedValue",
            propertyType: typeof(double),
            ownerType: typeof(AnimatedPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion TransformedValue Property

        #region TransformProgress Property

        /// <summary>
        /// A percentage value representing the progress of the Pane's transformation.
        /// Gets the current TransformProgress of the Pane. This is handled internally by the Pane using the Open and Close TransformAnimations.
        /// </summary>
        [Category("Layout")]
        [Description("A percentage value representing the progress of the Pane's transformation.\nGets the current TransformProgress of the Pane. This is handled internally by the Pane using the Open and Close TransformAnimations.")]
        public double TransformProgress
        {
            get => (double)GetValue(TransformProgressProperty);
            set => SetValue(TransformProgressProperty, value);
        }

        public static readonly DependencyProperty TransformProgressProperty = DependencyProperty.Register(
            name: "TransformProgress",
            propertyType: typeof(double),
            ownerType: typeof(AnimatedPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion TransformProgress Property

        #region IsOpen Property

        /// <summary>
        /// Gets or sets whether the Pane is open or not.
        /// </summary>
        [Category("Layout")]
        [Description("Gets or sets whether the Pane is open or not.")]
        public bool IsOpen
        {
            get => (bool)GetValue(IsOpenProperty);
            set => SetValue(IsOpenProperty, value);
        }

        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register(
            name: "IsOpen",
            propertyType: typeof(bool),
            ownerType: typeof(AnimatedPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(bool),
                propertyChangedCallback: OnIsOpenChanged));

        /// <summary>
        /// Starts animation for the TransformProgress when IsOpen is changed.
        /// Raises the corresponding Event.
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private static void OnIsOpenChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            AnimatedPane instance = sender as AnimatedPane;
            if (instance.IsOpen)
            {
                instance.RaiseEvent(new RoutedEventArgs(PaneOpenedEvent));
                instance.BeginAnimation(TransformProgressProperty, instance.OpenTransformAnimation);
            }
            else
            {
                instance.RaiseEvent(new RoutedEventArgs(PaneClosedEvent));
                instance.BeginAnimation(TransformProgressProperty, instance.CloseTransformAnimation);
            }
        }

        #endregion IsOpen Property

        #endregion Dependency Properties

        private void TransformProgressInit()
        {
            if (IsTransformInverted)
            {
                TransformProgress = IsOpen ? 0 : 1;
            }
            else
            {
                TransformProgress = IsOpen ? 1 : 0;
            }
        }

        public override void EndInit()
        {
            base.EndInit();
            TransformProgressInit();
        }

        static AnimatedPane()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(AnimatedPane),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(AnimatedPane)));
        }
    }
}