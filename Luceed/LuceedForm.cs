using Luceed.Models;
using System.Net;
using System.Text.Json;

namespace Luceed
{
    public partial class LuceedForm : Form
    {
        HttpClient client = new HttpClient();
        public LuceedForm()
        {
            InitializeComponent();

        }

        private async void btnGetByNaziv_Click(object sender, EventArgs e)
        {
            try
            {
                List<Article> artikli = new List<Article>();
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:7071/api/Article/{txtNaziv.Text}");
                var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    string message = "Error na serveru.";
                    string caption = "Server Error";
                    DisplayPopup(message, caption, MessageBoxIcon.Error);
                }


                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resBody = await response.Content.ReadAsStringAsync();
                    artikli = JsonSerializer.Deserialize<List<Article>>(resBody);

                    if (artikli.Count == 0)
                    {
                        string message = "Ništa nije nadeno pod tim nazivom.";
                        string caption = "Nema Rezultata";
                        DisplayPopup(message, caption, MessageBoxIcon.Warning);
                        return;
                    }

                    artikli.ForEach(artikl =>
                    {
                        DataGridViewRow row = (DataGridViewRow)gridArtikli.Rows[0].Clone();
                        var asd = row.Cells;
                        row.Cells[0].Value = artikl.Id;
                        row.Cells[1].Value = artikl.Naziv;
                        gridArtikli.Rows.Add(row);
                    });
                }
            }
            catch (Exception ex)
            {
                string message = $"{ex.Message}";
                string caption = "Error";
                DisplayPopup(message, caption, MessageBoxIcon.Error);
            }


        }


        private void DisplayPopup(string message, string caption, MessageBoxIcon icon)
        {

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            dtTo.Enabled = chkEnable.Checked;
        }

        private void btnClearArticle_Click(object sender, EventArgs e)
        {
            gridArtikli.Rows.Clear();
        }

        private void btnClearPaymentType_Click(object sender, EventArgs e)
        {
            gridPaymentType.Rows.Clear();
        }

        private async void btnGetByPaymentType_Click(object sender, EventArgs e)
        {
            string bu = txtBU.Text;
            bool onlyNumbers = bu.Replace("-", "").All(char.IsDigit);
            if (string.IsNullOrEmpty(bu) || !onlyNumbers)
            {
                string message = "Business unit must have value and contain no letters.";
                string caption = "Need input";
                DisplayPopup(message, caption, MessageBoxIcon.Warning);
                return;
            }

            int fromDay = dtFrom.Value.Day;
            int fromMonth = dtFrom.Value.Month;
            int fromYear = dtFrom.Value.Year;
            string fromDate = $"{fromDay}.{fromMonth}.{fromYear}";

            int toDay, toMonth, toYear;
            string toDate = string.Empty;
            if (dtTo.Enabled)
            {
                toDay = dtTo.Value.Day;
                toMonth = dtTo.Value.Month;
                toYear = dtTo.Value.Year;
                toDate = $"{toDay}.{toMonth}.{toYear}";

            }

            string apiUrl = $"https://localhost:7071/api/TransactionPaymentType/{bu}/{fromDate}";
            if (!string.IsNullOrEmpty(toDate))
            {
                apiUrl += $"/{toDate}";
            }

            try
            {
                List<ObracunPlacanja> obracuniPlacanja = new List<ObracunPlacanja>();
                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    string message = "Error na serveru.";
                    string caption = "Server Error";
                    DisplayPopup(message, caption, MessageBoxIcon.Error);
                }

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resBody = await response.Content.ReadAsStringAsync();
                    obracuniPlacanja = JsonSerializer.Deserialize<List<ObracunPlacanja>>(resBody);

                    if (obracuniPlacanja.Count == 0)
                    {
                        string message = "Ništa nije nadeno za te parametre.";
                        string caption = "Nema Rezultata";
                        DisplayPopup(message, caption, MessageBoxIcon.Warning);
                        return;
                    }

                    obracuniPlacanja.ForEach(obracun =>
                    {
                        DataGridViewRow row = (DataGridViewRow)gridPaymentType.Rows[0].Clone();
                        var asd = row.Cells;
                        row.Cells[0].Value = obracun.Id;
                        row.Cells[1].Value = obracun.Naziv;
                        row.Cells[2].Value = obracun.Iznos;
                        row.Cells[3].Value = obracun.NadgrupaPlacanjaId;
                        row.Cells[4].Value = obracun.NadgrupaPlacanjaNaziv;
                        gridPaymentType.Rows.Add(row);
                    });
                }
            }
            catch (Exception ex)
            {
                string message = $"{ex.Message}";
                string caption = "Error";
                DisplayPopup(message, caption, MessageBoxIcon.Error);
            }



        }
    }


}