namespace DEINT_PagoPerfecto;

public partial class MainPage : ContentPage
{
    private double resultadoTotal, propinaTotal;

	public MainPage()
	{
		InitializeComponent();
    }

    private void btn10_Clicked(object sender, EventArgs e)
    {
        sliderPropina.Value = 10;
        calcularPago();
    }

    private void btn15_Clicked(object sender, EventArgs e)
    {
        sliderPropina.Value = 15;
        calcularPago();
    }

    private void btn20_Clicked(object sender, EventArgs e)
    {
        sliderPropina.Value = 20;
        calcularPago();
    }

    private void cuenta_TextChanged(object sender, TextChangedEventArgs e)
    {
        calcularPago();
    }

    private void sliderPropina_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        calcularPago();
    }

    private void btnMenos_Clicked(object sender, EventArgs e)
    {
        numPersonas.Text = (Int16.Parse(numPersonas.Text) - 1) + "";
        calcularPago();
    }

    private void btnMas_Clicked(object sender, EventArgs e)
    {
        numPersonas.Text = (Int16.Parse(numPersonas.Text) + 1) + "";
        calcularPago();
    }

    private void calcularPago()
    {
        try
        {
            propinaTotal = double.Parse(cuenta.Text) * (sliderPropina.Value / 100);
            resultadoTotal = double.Parse(cuenta.Text) + propinaTotal;

            total.Text = resultadoTotal / double.Parse(numPersonas.Text) + "";
            propina.Text = propinaTotal / double.Parse(numPersonas.Text) + "";
            subtotal.Text = (double.Parse(total.Text) - double.Parse(propina.Text)) + "";

            error.Text = "";
        }
        catch (System.Exception ex)
        {
            error.Text = "Error, datos mal introducidos.";
        }
    }
}

