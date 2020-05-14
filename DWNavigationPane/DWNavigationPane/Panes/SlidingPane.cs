using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace DWNavigationPane
{
    /// <summary>
    /// Indicates where the Pane should slide
    /// </summary>
    public enum SlideDirection
    {
        Right = -1,
        Left = 1
    }

    /// <summary>
    /// An animated Pane that slides when it opens.
    /// </summary>
    public class SlidingPane : AnimatedPane
    {
        #region Dependency Properties

        #region SlideDirection Property

        /// <summary>
        /// Indicates where the Pane should slide.
        /// </summary>
        [Category("Common")]
        [Description("Indicates where the Pane should slide.")]
        public SlideDirection SlideDirection
        {
            get => (SlideDirection)GetValue(SlideDirectionProperty);
            set => SetValue(SlideDirectionProperty, value);
        }

        public static readonly DependencyProperty SlideDirectionProperty = DependencyProperty.Register(
            name: "SlideDirection",
            propertyType: typeof(SlideDirection),
            ownerType: typeof(SlidingPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(SlideDirection)));

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

        static SlidingPane()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(SlidingPane),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(SlidingPane)));
        }
    }
}