// Evento para calcular temperaturas
using System;
using System.Windows.Forms;

private void btnCalcularTemps_Click(object sender, EventArgs e)
{
    if (!String.IsNullOrEmpty(tbfahrenheit.Text) && !String.IsNullOrEmpty(tbkelvin.Text))
    {
        tbCelcius.Text = "";
    }
    else if (!String.IsNullOrEmpty(tbCelcius.Text))
    {
        MessageBox.Show("Calculando");
        float Ce = float.Parse(tbCelcius.Text);
        float Fa2 = (Ce * 9f / 5f) + 32f;
        float Ke = Ce + 273.15f;
        tbFahrenheit.Text = Fa2.ToString();
        tbKelvin.Text = Ke.ToString();
    }
    else if (!String.IsNullOrEmpty(tbfahrenheit.Text))
    {
        float Fa = float.Parse(tbfahrenheit.Text);
        float Ce2 = (Fa - 32f) * 5f / 9f;
        float Ke = Ce2 + 273.15f;
        tbCelcius.Text = Ce2.ToString();
        tbKelvin.Text = Ke.ToString();
    }
    else if (!String.IsNullOrEmpty(tbkelvin.Text))
    {
        float Ke = float.Parse(tbkelvin.Text);
        float Ce = Ke - 273;
        tbcelcius.Text = Ce.ToString();
        float Fa2 = (Ce * 9 / 5) + 32;
        tbfahrenheit.Text = Fa2.ToString();
    }
    else
    {
        MessageBox.Show("Ingrese valores para el calculo de temperatura");
    }
}

// Evento alternativo para calcular temperaturas (otro botón)
private void btnTemps_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrEmpty(tbcCelsius.Text))
    {
        float Ce = float.Parse(tbcCelsius.Text);
        float Fa = (Ce * 9 / 5) + 32;
        float Ke = Ce + 273.15f;

        MessageBox.Show("Calculando");
        tbcFahrenheit.Text = Fa.ToString();
        tbcKelvin.Text = Ke.ToString();
    }

    if (!string.IsNullOrEmpty(tbcFahrenheit.Text))
    {
        float Fa = float.Parse(tbcFahrenheit.Text);
        float Ce = (Fa - 32) * 5 / 9;
        float Ke = Ce + 273.15f;

        tbcCelsius.Text = Ce.ToString();
        tbcKelvin.Text = Ke.ToString();
    }

    if (!string.IsNullOrEmpty(tbcKelvin.Text))
    {
        float Ke = float.Parse(tbcKelvin.Text);
        float Ce = Ke - 273.15f;
        float Fa = (Ce * 9 / 5) + 32;

        tbcCelsius.Text = Ce.ToString();
        tbcFahrenheit.Text = Fa.ToString();
    }
}

// Evento para borrar los valores
private void btnBorrar_Click(object sender, EventArgs e)
{
    MessageBox.Show("Se Borraron los valores del los TextBox");
    //tbCelcius.Text="0";
    //tbFahrenheit.Text="0";
    tbCelcius.Text = "";
    tbFahrenheit.Clear();
    tbKelvin.Clear();
}
