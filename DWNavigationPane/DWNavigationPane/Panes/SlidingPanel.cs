using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace DWNavigationPane
{
    /// <summary>
    /// Indicates where the Pane should slide horizontally
    /// </summary>
    public enum HorizontalSlideDirection
    {
        Right = -1,
        Left = 1
    }

    /// <summary>
    /// An Panel that slides when it opens.
    /// </summary>
    public class SlidingPanel : AnimatedPane
    {
        #region Dependency Properties

        #region SlideDirection Property

        /// <summary>
        /// Indicates where the Panel should slide.
        /// </summary>
        [Category("Common")]
        [Description("Indicates where the Pane should slide.")]
        public HorizontalSlideDirection SlideDirection
        {
            get => (HorizontalSlideDirection)GetValue(SlideDirectionProperty);
            set => SetValue(SlideDirectionProperty, value);
        }

        public static readonly DependencyProperty SlideDirectionProperty = DependencyProperty.Register(
            name: "SlideDirection",
            propertyType: typeof(HorizontalSlideDirection),
            ownerType: typeof(SlidingPanel),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(HorizontalSlideDirection)));

        #endregion SlideDirection Property

        #endregion Dependency Properties

        private void TransformBindingsInit()
        {
            Binding binding = new Binding("TransformedValue") { Source = this };
            TranslateTransform transform = new TranslateTransform();
            BindingOperations.SetBinding(transform, TranslateTransform.XProperty, binding).UpdateTarget();
            RenderTransform = transform;
        }

        public override void EndInit()
        {
            base.EndInit();
            TransformBindingsInit();
        }

        static SlidingPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(SlidingPanel),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(SlidingPanel)));
        }
    }
}