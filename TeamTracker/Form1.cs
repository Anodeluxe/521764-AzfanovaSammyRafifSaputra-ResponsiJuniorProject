using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.DirectoryServices;

namespace TeamTracker
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Username=postgres;Password=usti;Database=TeamTracker";
        private Developer currentDeveloper;  //ENCAPSULATION
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            LoadData();
            LoadComboBox();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM public.developer";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT id_proyek FROM public.developer";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_Proyek.Items.Add(reader.GetString(0));
                }
                reader.Close();
                query = "SELECT DISTINCT status_kontrak FROM public.developer";
                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_Status.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        //Encapsulation - setting current developer
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                currentDeveloper = new Developer(
                    int.Parse(row.Cells["id"].Value.ToString()),
                    row.Cells["nama_dev"].Value.ToString(),
                    row.Cells["id_proyek"].Value.ToString(),
                    int.Parse(row.Cells["fitur_selesai"].Value.ToString()),
                    int.Parse(row.Cells["jumlah_bug"].Value.ToString()),
                    row.Cells["status_kontrak"].Value.ToString()
                );
                // Populate form fields
                tb_Nama.Text = currentDeveloper.NamaDev;
                cb_Proyek.SelectedItem = currentDeveloper.NamaProyek;
                tb_Fitur.Text = currentDeveloper.FiturSelesai.ToString();
                tb_Bug.Text = currentDeveloper.JumlahBug.ToString();
                cb_Status.SelectedItem = currentDeveloper.StatusKontrak;
            }
        }

        private void cb_Proyek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //INSERT - polymorphism 
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseOperation insertOp = new InsertOperation(
                    connString,
                    tb_Nama.Text,
                    cb_Proyek.SelectedItem.ToString(),
                    int.Parse(tb_Fitur.Text),
                    int.Parse(tb_Bug.Text),
                    cb_Status.SelectedItem.ToString()
                );
                if (insertOp.Execute())
                {
                    MessageBox.Show("Data inserted successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Insert operation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //UPDATE - polymorphism
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (currentDeveloper == null)
            {
                MessageBox.Show("Please select a developer to update.");
                return;
            }
            try
            {
                DatabaseOperation updateOp = new UpdateOperation(
                    connString,
                    currentDeveloper.Id,
                    tb_Nama.Text,
                    cb_Proyek.SelectedItem.ToString(),
                    int.Parse(tb_Fitur.Text),
                    int.Parse(tb_Bug.Text),
                    cb_Status.SelectedItem.ToString()
                );
                if (updateOp.Execute())
                {
                    MessageBox.Show("Data updated successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update operation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        //DELETE - polymorphism
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (currentDeveloper == null)
            {
                MessageBox.Show("Please select a developer to delete.");
                return;
            }
            try
            {
                DatabaseOperation deleteOp = new DeleteOperation(
                    connString,
                    currentDeveloper.Id
                );
                if (deleteOp.Execute())
                {
                    MessageBox.Show("Data deleted successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Delete operation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }

    // abstraction
    public abstract class DatabaseOperation
    {
        protected string connString;

        public DatabaseOperation(string connectionString)
        {
            connString = connectionString;
        }

        public abstract bool Execute();
    }

    //INheritance & Polymorphism
    public class InsertOperation : DatabaseOperation
    {
        private string nama, proyek, statusKontrak;
        private int jumlahFitur, jumlahBug;
        public InsertOperation(string connectionString, string nama, string proyek, int jumlahFitur, int jumlahBug, string statusKontrak)
            : base(connectionString)
        {
            this.nama = nama;
            this.proyek = proyek;
            this.jumlahFitur = jumlahFitur;
            this.jumlahBug = jumlahBug;
            this.statusKontrak = statusKontrak;
        }

        public override bool Execute()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO public.developer (nama_dev, id_proyek, fitur_selesai, jumlah_bug, status_kontrak) " +
                               "VALUES (@nama, @proyek, @jumlah_fitur, @jumlah_bug, @status_kontrak)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("proyek", proyek);
                    cmd.Parameters.AddWithValue("jumlah_fitur", jumlahFitur);
                    cmd.Parameters.AddWithValue("jumlah_bug", jumlahBug);
                    cmd.Parameters.AddWithValue("status_kontrak", statusKontrak);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }

    //inheritance & polymorphism
    public class UpdateOperation : DatabaseOperation
    {
        private int id;
        private string nama, proyek, statusKontrak;
        private int jumlahFitur, jumlahBug;
        public UpdateOperation(string connectionString, int id, string nama, string proyek, int jumlahFitur, int jumlahBug, string statusKontrak)
            : base(connectionString)
        {
            this.id = id;
            this.nama = nama;
            this.proyek = proyek;
            this.jumlahFitur = jumlahFitur;
            this.jumlahBug = jumlahBug;
            this.statusKontrak = statusKontrak;
        }
        public override bool Execute()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE public.developer SET nama_dev = @nama, id_proyek = @proyek, fitur_selesai = @jumlah_fitur, " +
                                "jumlah_bug = @jumlah_bug, status_kontrak = @status_kontrak WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("proyek", proyek);
                    cmd.Parameters.AddWithValue("jumlah_fitur", jumlahFitur);
                    cmd.Parameters.AddWithValue("jumlah_bug", jumlahBug);
                    cmd.Parameters.AddWithValue("status_kontrak", statusKontrak);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }

    // inheritance & polymorphism  - DeleteOperation
    public class DeleteOperation : DatabaseOperation
    {
        private int id;
        public DeleteOperation(string connectionString, int id)
            : base(connectionString)
        {
            this.id = id;
        }
        public override bool Execute()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM public.developer WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }

    //encapsulation - model class developer
    public class Developer
    {
        //private fields
        private int id;
        private string namaDev;
        private string namaProyek;
        private int fiturSelesai;
        private int jumlahBug;
        private string statusKontrak;

        public int Id { get; set; }
        public string NamaDev { get; set; }
        public string NamaProyek { get; set; }
        public int FiturSelesai { get; set; }
        public int JumlahBug { get; set; }
        public string StatusKontrak { get; set; }

        public Developer(int id, string namaDev, string namaProyek, int fiturSelesai, int jumlahBug, string statusKontrak)
        {
            Id = id;
            NamaDev = namaDev;
            NamaProyek = namaProyek;
            FiturSelesai = fiturSelesai;
            JumlahBug = jumlahBug;
            StatusKontrak = statusKontrak;
        }

        public string GetDeveloperInfo()
        {
            return $"ID: {Id}, Nama: {NamaDev}, Proyek: {NamaProyek}, Fitur Selesai: {FiturSelesai}, Jumlah Bug: {JumlahBug}, Status Kontrak: {StatusKontrak}";
        }
    }


}
