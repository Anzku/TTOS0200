using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra05
{
    class T2
    {
        public static void Test()
        {
            CD disk1 = new CD("Endless Forms Most Beautiful - 1", "Nightwish");
            
            disk1.AddSong("Shudder Before the Beautiful", 385);
            Song kappale = new Song("Weak Fantasy", 246);
            disk1.AddSong(kappale);
            List<Song> newList = new List<Song>();
            newList.Add(new Song("Elan", 244));
            newList.Add(new Song("Yours Is an Empty Hope", 478));
            newList.Add(new Song("Our Decades in the Sun", 189));
            newList.Add(new Song("My Waldenn", 936));
            newList.Add(new Song("Endless Forms Most Beautiful", 15680));
            newList.Add(new Song("Edema Ruh", 603));
            disk1.AddSong(newList);
            Console.WriteLine(disk1.ToString());
        }
    }
    class CD
    {
        #region PROPERTIES
        string Name { get; set; }
        string Artist { get; set; }
        List<Song> Songs = new List<Song>();
        #endregion
        #region CONSTRACTORS
        public CD (string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
        public CD (string name, string artist, List<Song> songs)
            : this(name,artist)
        {
            Songs = songs;
        }
        #endregion
        #region METHODS
        public void AddSong(Song newSong)
        {
            Songs.Add(newSong);
        }
        public void AddSong(string name, int time)
        {
            Songs.Add(new Song(name, time));
        }
        public void AddSong(List<Song> listOfSongs)
        {
            foreach (Song kappale in listOfSongs)
            {
                Songs.Add(kappale);
            }
        }
        public override string ToString()
        {
            string text = string.Format("CD data:\n- name: {0}\n- artist: {1}\n-songs:\n",Name,Artist);
            foreach (Song item in Songs)
            {
                text += item.ToString();
            }
            return text;
        }
        #endregion
    }
    class Song
    {
        string Name { get; set; }
        int TimeSec { get; set; }
        public Song (string name, int timeSec)
        {
            Name = name;
            TimeSec = timeSec;
        }
        public override string ToString()
        {
            int min = TimeSec / 60;
            int sec = TimeSec % 60;
            string nolla = "";
            if (sec < 10) nolla = "0";
            
            return string.Format(" - {0}, {1}:{2}{3}\n", Name, min, nolla, sec);
        }
    }
}
