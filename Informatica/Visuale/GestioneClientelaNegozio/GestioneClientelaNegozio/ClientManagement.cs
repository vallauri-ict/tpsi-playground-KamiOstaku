using System.Windows.Forms;

namespace GestioneClientelaNegozio
{
    public partial class ClientManagement : Form
    {
        public class Cliente
        {
            private Random rnd = new Random();

            public string name;
            public int orderCode;
            public double orderPrice;
            public string product;

            public Cliente(string name, double price, string product, int matricola)
            {
                this.name = name;
                this.orderCode = rnd.Next(matricola + 1, matricola + 21);
                this.orderPrice = price;
                this.product = product;
            }
        };

        List<double> priceList = new List<double>();
        List<Cliente> ordini = new List<Cliente>();

        public ClientManagement()
        {
            InitializeComponent();
        }

        public static int matricola = 0;

        private void ClientManagement_Load(object sender, EventArgs e)
        {
            SetDgv();
            SetLists();
        }

        private void SetLists()
        {
            ListaProdotti.Items.Add("Pizza surgelata");
            ListaProdotti.Items.Add("Gelati Magnum");
            ListaProdotti.Items.Add("Banane Cichita");

            priceList.Add(15.00);
            priceList.Add(13.9);
            priceList.Add(8.00);

        }

        private void SetDgv()
        {
            DisplayStruct.ColumnCount = 4;
            DisplayStruct.RowCount = 1;

            for (int i = 0; i < 4; i++)
            {
                DisplayStruct.Columns[i].Width = 151;
            }

            DisplayStruct.Columns[0].HeaderText = "Name".PadLeft(15);
            DisplayStruct.Columns[1].HeaderText = "Product".PadLeft(17);
            DisplayStruct.Columns[2].HeaderText = "Order Code".PadLeft(17);
            DisplayStruct.Columns[3].HeaderText = "Order Price".PadLeft(19);
        }

        private void SubmitClient_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string name = InputName.Text;
            string prodotto = ListaProdotti.Text;
            double prezzo = double.Parse(InputQuantity.Text) * priceList[ListaProdotti.SelectedIndex];


            ordini.Add(new Cliente(name, prezzo, prodotto, matricola));

            DisplayStruct.Rows[ordini.Count - 1].Cells[0].Value = ordini[ordini.Count - 1].name;
            DisplayStruct.Rows[ordini.Count - 1].Cells[1].Value = ordini[ordini.Count - 1].product;
            DisplayStruct.Rows[ordini.Count - 1].Cells[2].Value = ordini[ordini.Count - 1].orderCode;
            DisplayStruct.Rows[ordini.Count - 1].Cells[3].Value = ordini[ordini.Count - 1].orderPrice;
            DisplayStruct.Rows.Add();

            matricola += rnd.Next(5, 101);

            InputName.Text = "";
            InputQuantity.Text = "";
        }

        private void btnUndoRegistration_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool superato = false, trovato = false;

            while (i < ordini.Count && !superato && !trovato)
            {
                if (ordini[i].orderCode == int.Parse(matricolaAnnullamento.Text))
                {
                    trovato = true;
                }
                else if (ordini[i].orderCode > Convert.ToInt32(matricolaAnnullamento.Text))
                {
                    superato = true;
                }
                else
                {
                    i++;
                }
            }

            if (trovato)
            {
                DisplayStruct.Rows.RemoveAt(i);
                ordini.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Codice ordine non esistente");
            }

            matricolaAnnullamento.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaProdotti.Items.Add(inputAddProduct.Text);
            priceList.Add(Convert.ToInt32(inputPrice.Text));

            inputAddProduct.Text = "";
            inputPrice.Text = "";
        }

        private void Check_Key(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 65 || e.KeyValue > 90) && e.KeyValue != 8)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void KeyNumberCheck(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());

            if ((e.KeyValue < 48 || e.KeyValue > 53))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
