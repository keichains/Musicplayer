using musicplayerdesign.customButton;
using musicplayerdesign.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayerdesign
{
    public partial class playlist1Page : UserControl
    {
        public playlist1Page()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            OnAutoNext.Visible = true;
            OnRepeating.Visible = false;
            this.LostFocus += PlaylistForm_LostFocus;
            SearchBox.LostFocus += PlaylistForm_LostFocus;
            this.ActiveControl = null;

            ResetProperties();
            PlayMusicList.Volume = 100;
        }

        // Reset lại các thuộc tính điều khiển chung của app
        private void ResetProperties()
        {
            PlayMusicList = new Playlist();
            PlayMusicList.StopAndDisposePlayerDevice();
            PlayMusicList.NewAudioFile += StartNewMusic;
            PlayMusicList.FinishPlayingFile += EndMusic;
            PlayMusicList.Tick += TimerTick;
            PlayMusicList.PrepareToPlay();
            PlayMusicList.Pause();

            this.Controls.Remove(this.Controls["MusicList"]);
            MusicList = new MusicListPanel(PlayMusicList, Path.Combine(Directory.GetCurrentDirectory(), "PlaylistFiles"));
            this.Controls.Add(MusicList);
            {
                MusicList.Name = "MusicList";
                MusicList.Location = new Point(127, 170);
                MusicList.UpperLimit = CoverImage.Location.Y + CoverImage.Height;
                MusicList.LowerLimit = PlayPanel.Location.Y;
                MusicList.Trash = Trash;
                MusicList.PlayPauseButton = this.PlayButton;
                MusicList.ChoosingAnotherMusic += MusicList_ChoosingAnotherMusic;
            }

            MusicList.InitializeComponent();
        }

        // Tắt đường viền của thanh trượt khi focus bằng cách chuyển focus sang form chính.
        private void PlaylistForm_LostFocus(object sender, EventArgs e)
        {
            if (!SearchBox.ContainsFocus) this.Focus();
        }

        private MusicListPanel MusicList; // Hiển thị danh sách bài hát (hình ảnh, nút play, tên, thời lượng)
        private Playlist PlayMusicList; // Dùng để phát nhạc tích hợp danh sách liên kết đôi
        private int VolumeWas; // Dùng để hồi phục lại vị trí cũ của thanh âm lượng khi nhấn nút loa

        // Khi bắt đầu phát bài hát mới
        private void StartNewMusic(object sender, EventArgs e)
        {
            PlayMusicList.Volume = SpeakerBar.Value;
            MusicBar.Maximum = PlayMusicList.TotalTime;
            MusicBar.Value = 0;

            MusicName.Text = Path.GetFileNameWithoutExtension(PlayMusicList.CurrentNode.FileName);

            CurrentTime.Text = "0:00";
            TotalTime.Text = PlayMusicList.TotalTime > 3600 ?
                string.Format("{0:h\\:mm\\:ss}", TimeSpan.FromSeconds(PlayMusicList.TotalTime)) :
                string.Format("{0:m\\:ss}", TimeSpan.FromSeconds(PlayMusicList.TotalTime));
        }

        // Khi bài hát kết thúc
        private void EndMusic(object sender, EventArgs e)
        {
            if (!(PlayMusicList.AutoNext || PlayMusicList.Repeating))
                PlayButton.Image = Resources.Play;

            MusicList.PlayClick(PlayMusicList.CurrentIndex);

            if (PlayMusicList.Repeating) MusicList.PlayClick(PlayMusicList.CurrentIndex);
        }

        // Thiết đặt hình ảnh hiển thị khi chọn một bài hát mới.
        private void MusicList_ChoosingAnotherMusic(object sender, EventArgs e)
        {
            ImageMusicPlaying.BackgroundImage?.Dispose();
            if (File.Exists(Path.Combine(MusicList.FilesPath, Path.GetFileNameWithoutExtension((MusicList.Current.Controls["ImageMusic"] as PictureBox).Tag.ToString()))))
            {
                try
                {
                    ImageMusicPlaying.BackgroundImage = new Bitmap((MusicList.Current.Controls["ImageMusic"] as PictureBox).Image);
                }
                catch { }
            }
        }

        // Timer Tick dùng để dịch chuyển vị trí thanh MusicBar
        private void TimerTick(object sender, EventArgs e)
        {
            if (MusicBar.Value < MusicBar.Maximum)
                MusicBar.Value++;

            CurrentTime.Text = PlayMusicList.CurrentTime > 3600 ?
                string.Format("{0:h\\:mm\\:ss}", TimeSpan.FromSeconds(PlayMusicList.CurrentTime)) :
                string.Format("{0:m\\:ss}", TimeSpan.FromSeconds(PlayMusicList.CurrentTime));
        }
        // Nhấn nút OpenFile
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog()
            {
                Filter = "MP3 Files (*.mp3)|*.mp3",
                Multiselect = true,
                Title = "Open Music Files"
            };

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string File in OpenFile.FileNames)
                {
                    if (!System.IO.File.Exists(Path.Combine(MusicList.FilesPath, Path.GetFileName(File))))
                        System.IO.File.Copy(File, Path.Combine(MusicList.FilesPath, Path.GetFileName(File)));
                }
                MusicList.PlayerDevice.StopAndDisposePlayerDevice();
                ResetProperties();
            }
        }

        // Nhấn nút Play
        private void PlayButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PlayMusicList.CurrentNode?.FileName))
            {
                if (MusicBar.Maximum == MusicBar.Value) PlayMusicList.PrepareToPlay();
                if (PlayMusicList.IsPlaying)
                {
                    PlayMusicList.Pause();

                }
                else
                {
                    PlayMusicList.Play();

                }
                MusicList.PlayClick(PlayMusicList.CurrentIndex);
            }
        }


        // Phát bài hát trước
        private void PreviousButton_Click_1(object sender, EventArgs e)
        {
            int Index = PlayMusicList.CurrentIndex - 1;
            if (Index < 0) Index = PlayMusicList.Count - 1;
            if (PlayMusicList.Count > 0) MusicList.PlayClick(Index);
        }

        // Phát bài hát sau
        private void NextButton_Click_1(object sender, EventArgs e)
        {
            int Index = PlayMusicList.CurrentIndex + 1;
            if (Index > PlayMusicList.Count - 1) Index = 0;
            if (PlayMusicList.Count > 0) MusicList.PlayClick(Index);
        }

        // Tự động phát bài tiếp theo
        private void AutoNextMusic_Click(object sender, EventArgs e)
        {
            PlayMusicList.AutoNext = !PlayMusicList.AutoNext;
            if (PlayMusicList.AutoNext) OnAutoNext.Visible = true;
            else OnAutoNext.Visible = false;
            OnRepeating.Visible = false;

            if (PlayMusicList.AutoNext && MusicBar.Value == MusicBar.Maximum) NextButton_Click_1(sender, e);
        }

        // Tự động lặp lại bài hát
        private void Repeating_Click(object sender, EventArgs e)
        {
            PlayMusicList.Repeating = !PlayMusicList.Repeating;
            if (PlayMusicList.Repeating) OnRepeating.Visible = true;
            else OnRepeating.Visible = false;
            OnAutoNext.Visible = false;

            if (PlayMusicList.Repeating && MusicBar.Value == MusicBar.Maximum)
                MusicList.PlayClick(PlayMusicList.CurrentIndex);
        }

        // Nhấn nút loa
        private void Speaker_Click(object sender, EventArgs e)
        {
            if (MusicBar.Value == MusicBar.Maximum) PlayButton_Click_1(sender, e);
            if (VolumeWas == 0) VolumeWas = 100;
            SpeakerBar.Value = SpeakerBar.Value == 0 ? VolumeWas : 0;
            PlayMusicList.Volume = SpeakerBar.Value;
        }

        // Cuộn thanh âm lượng
        private void SpeakerBar_Scroll(object sender, EventArgs e)
        {
            VolumeWas = SpeakerBar.Value;
            PlayMusicList.Volume = SpeakerBar.Value;
        }

        // Cuộn thanh phát nhạc
        private void MusicBar_Scroll(object sender, EventArgs e)
        {
            if (!PlayMusicList.IsPlaying) MusicList.PlayClick(PlayMusicList.CurrentIndex);

            PlayButton.Image = Resources.Pause;
            PlayMusicList.CurrentTime = MusicBar.Value;
            CurrentTime.Text = PlayMusicList.CurrentTime > 3600 ?
                string.Format("{0:h\\:mm\\:ss}", TimeSpan.FromSeconds(PlayMusicList.CurrentTime)) :
                string.Format("{0:m\\:ss}", TimeSpan.FromSeconds(PlayMusicList.CurrentTime));
        }

        // Bỏ dấu các kí tự tiếng Việt
        public static string RemoveDiacritics(string Text)
        {
            string NormalizedText = Text.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            return regex.Replace(NormalizedText, string.Empty).Normalize(NormalizationForm.FormC);
        }

        private bool SearchFlag = true;
        // Tìm kiếm nhạc
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                SearchFlag = false;
                string[] TempMusicFiles = MusicList.MusicFiles;

                // Chuẩn hoá ký tự tìm kiếm sang toàn bộ ký tự chữ thường, không dấu tiếng Việt
                string SearchTerm = RemoveDiacritics(SearchBox.Text.ToLower().Trim());

                List<string> Result = new List<string>();
                foreach (string FileName in TempMusicFiles)
                    if (!string.IsNullOrEmpty(FileName) && RemoveDiacritics(FileName.ToLower().Trim()).Contains(SearchTerm)) Result.Add(FileName);

                MusicList.MusicFiles = Result.ToArray();
                MusicList.InitializeComponent();

                MusicList.MusicFiles = TempMusicFiles;
                SearchFlag = true;
            }
        }
    }
}
