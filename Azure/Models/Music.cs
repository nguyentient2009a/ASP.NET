using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Models
{
    public class Music
    {
        public string Name { get; set; }

        public MusicCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Music(string name, MusicCategory category, string audioFile, string imgFile)
        {
            Name = name;
            Category = category;
            AudioFile = audioFile;
            ImageFile = imgFile;
        }
    }
    public enum MusicCategory
    {
        Ballad,
        Rap,
    }

    public class MusicManager
    {
        public static List<Music> GetMusics()
        {
            var musics = new List<Music>();

            musics.Add(new Music("HỒNG NHAN", MusicCategory.Ballad, "Assets/Musics/y2mate.com - JACK HỒNG NHAN OFFICIAL MV G5R.mp3", "Assets/Images/0.jpg"));
            musics.Add(new Music("Doi Loi Gui Den Anh Minh Nhua", MusicCategory.Rap, "Assets/Musics/y2mate.com - WOWY BROTHER GỬI ĐẾN ANH MINH NHỰA OFFICIAL MV.mp3", "Assets/Images/maxresdefault.jpg"));
            musics.Add(new Music("Thien Dang", MusicCategory.Ballad, "Assets/Musics/y2mate.com - WOWY THIÊN ĐÀNG ft JOLIPOLI tại ELLE SHOW Full version.mp3", "Assets/Images/maxresdefault2.jpg"));

            return musics;
        }

        public static void GetAllMusic(ObservableCollection<Music> music)
        {
            var allSounds = GetMusics();
            music.Clear();
            allSounds.ForEach(p => music.Add(p));
        }

        public static void GetMusicByCategory(ObservableCollection<Music> musics, MusicCategory musicCategory)
        {
            var allMusic = GetMusics();
            var filteredMusic = allMusic.Where(p => p.Category == musicCategory).ToList();
            musics.Clear();
            filteredMusic.ForEach(p => musics.Add(p));
        }

        public static void GetMusicByName(ObservableCollection<Music> musics, string name)
        {
            var allMusic = GetMusics();
            var filteredSounds = allMusic.Where(p => p.Name == name).ToList();
            musics.Clear();
            filteredSounds.ForEach(p => musics.Add(p));
        }
    }
}
