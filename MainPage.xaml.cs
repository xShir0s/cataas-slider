namespace CatassSlider
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
            
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            slider.MaximumHeightRequest = value;
          
           
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat";
            slider.Source = link;
       
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat/gif";
            slider.Source = link;
        
        }
    }

}
