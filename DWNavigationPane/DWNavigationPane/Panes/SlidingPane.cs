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
            MultiBinding multiBinding = new MultiBinding();
            multiBinding.Converter = new Converters.Mult3Converter();
            multiBinding.Bindings.Add(new Binding("TransformProgress") { Source = this });
            multiBinding.Bindings.Add(new Binding("Width") { Source = this });
            multiBinding.Bindings.Add(new Binding("SlideDirection")
            {
                Source = this,
                Converter = new Converters.EnumToDoubleConverter()
            });
            TranslateTransform transform = new TranslateTransform();
            BindingOperations.SetBinding(transform, TranslateTransform.XProperty, multiBinding).UpdateTarget();
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