using Luceed.Models;
using System.Data;
using System.Net;
using System.Text.Json;
using System.Xml.Serialization;

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
        private void btnOcisti_Click(object sender, EventArgs e)
        {
            gridArtikli.Rows.Clear();
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
    }


}