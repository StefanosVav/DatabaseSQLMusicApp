using System.Windows.Forms;

namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            // Connect the list to the grid view control

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/thumb/3/3f/Ed_Sheeran_%2B_cover.png/220px-Ed_Sheeran_%2B_cover.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            // Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show("You clicked row " + rowClicked);

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            //MessageBox.Show("URL=" + imageURL);
            try
            {
                pictureBox1.Load(imageURL);
            }
            catch (Exception ex) { }


            tracksBindingSource.DataSource = albums[rowClicked].Tracks;

            dataGridView2.DataSource = tracksBindingSource;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // add a new item to the database
            Album album = new Album()
            {
                AlbumName = txt_AlbumName.Text,
                ArtistName = txt_ArtistName.Text,
                Year = Int32.Parse(txt_Year.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_Description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);

            MessageBox.Show(result + "new row(s) inserted!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            //MessageBox.Show("You clicked row " + rowClicked);

            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            //MessageBox.Show("ID of track " + trackID);

            AlbumsDAO albumsDAO = new AlbumsDAO();

            int result = albumsDAO.deleteTrack(trackID);

            dataGridView2.DataSource = null;
            albums = albumsDAO.getAllAlbums();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;

            String videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            webView21.Source = new Uri(videoURL);
        }
    }
}