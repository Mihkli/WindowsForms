using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Currencybox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetRatesBTN_Click(object sender, EventArgs e)
        {
            if (Currencybox.SelectedItem.ToString() == "EUR")
            {
                ResultLabel.Visible = true;
                Result.Visible = true;

                BitcoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBTC.Text);
                float currentRate = resultRates.bpi.EUR.rate_float;
                float btcresult = userCoins * currentRate;
                Result.Text = $"{btcresult} {resultRates.bpi.EUR.code}";
            }
            if (Currencybox.SelectedItem.ToString() == "USD")
            {
                ResultLabel.Visible = true;
                Result.Visible = true;

                BitcoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBTC.Text);
                float currentRate = resultRates.bpi.USD.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.USD.code}";
            }
            if (Currencybox.SelectedItem.ToString() == "GBP")
            {
                ResultLabel.Visible = true;
                Result.Visible = true;

                BitcoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBTC.Text);
                float currentRate = resultRates.bpi.GBP.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.GBP.code}";
            }
        }
        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            BitcoinRates bitcoin;

            var webRespone = request.GetResponse();
            var webStream = webRespone.GetResponseStream();

            using (var responeReader = new StreamReader(webStream))
            {
                var response = responeReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(response);
            }
            return bitcoin;
        }
    }
}
