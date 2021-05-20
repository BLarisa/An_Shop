using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CurrencyForm : Form
    {
        public CurrencyForm()
        {
            InitializeComponent();
            updateCurrency();
        }

        private static string get(string url)
        {
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            Stream out_stream = response.GetResponseStream();
            StreamReader out_reader = new StreamReader(out_stream);
            string str_response = out_reader.ReadToEnd();
            out_reader.Close();
            out_stream.Close();

            return str_response;
        }

        private void updateCurrency()
        {
            string resp = get("https://www.cbr-xml-daily.ru/daily_json.js");

            Currency currency = JsonSerializer.Deserialize<Currency>(resp);

            double dollar = currency.Valute["USD"].Value;
            dollarLabel.Text = $"1 доллар = {dollar} руб.";

            double euro = currency.Valute["EUR"].Value;
            euroLabel.Text = $"1 евро = {euro} руб.";
        }
    }
}
