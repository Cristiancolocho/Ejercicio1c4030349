namespace Ejercicio1c4030349;

public partial class Numeros : ContentPage
{
	public Numeros()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

         if (!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text)&& !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text))
         {
            double nu1, nu2, nu3, nu4;

            nu1 = Convert.ToDouble(entry1.Text);
            nu2 = Convert.ToDouble(entry2.Text);
            nu3 = Convert.ToDouble(entry3.Text);
            nu4 = Convert.ToDouble(entry4.Text);
            entryr.Text=(nu4, nu3, nu2, nu1).ToString();
         }
    }
}