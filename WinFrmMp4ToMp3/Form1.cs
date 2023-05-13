using System.Diagnostics;

namespace WinFrmMp4ToMp3;

public partial class Form1 : Form
{
    private string? videoPath, videoName, musicPath, musicName;

    public Form1()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(videoName))
        {
            MessageBox.Show("Vídeo Mp4 não identificado!");
        }
        else
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicPath = folderBrowserDialog.SelectedPath;
                musicName = videoName?.Substring(0, videoName.Length - 4);
                musicPath += string.Format("\\{0}{1}", musicName, ".mp3");
            }

            txtOutput.Text = musicPath;
        }

    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Multiselect = false,
            Filter = "MP4 File |* .mp4"

        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            videoPath = openFileDialog.FileName;
            videoName = openFileDialog.SafeFileName;
        }

        txtInput.Text = videoPath;
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(txtInput.Text?.Trim()))
                MessageBox.Show("Não foi possível identificar o vídeo!");
            else if (string.IsNullOrEmpty(txtOutput.Text?.Trim()))
                MessageBox.Show("Não foi possível identificar o caminho de destino para salvar o mp3!");
            else
            {
                var nrConvert = new NReco.VideoConverter.FFMpegConverter();
                nrConvert.ConvertMedia(txtInput.Text.Trim(), txtOutput.Text.Trim(), "mp3");

                MessageBox.Show("Arquivo convertido com Sucesso!");

                ClearVars();
            }

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.StackTrace);
            MessageBox.Show(ex.Message);
        }

    }

    private void ClearVars()
    {
        videoName = videoPath = musicName = musicPath = string.Empty;
        txtInput.Text = txtOutput.Text = string.Empty;
    }
}