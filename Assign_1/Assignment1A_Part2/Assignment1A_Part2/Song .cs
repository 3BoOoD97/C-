using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment1A_Part2
{
    class Song

    {
        private string songName;
        private string singerName;
        private DateTime releaseDate;
        private int numOfTracks;
        public Song(string songName , string singerName , DateTime releaseDate, int numOfTracks)
        {
            this.songName = songName;
            this.singerName = singerName;
            this.releaseDate = releaseDate;
            this.numOfTracks = numOfTracks;
        }

        public Song()
        {

        }
       

        public void start()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine(" Welcome To My Favorite Song\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            string songName;
            string singerName;
            DateTime releaseDate;
            int numOfTracks;

            Console.WriteLine("\nSong Name  :");
            songName = Console.ReadLine();
            Console.WriteLine("Singer Name :");
            singerName = Console.ReadLine();
            Console.WriteLine("Release Date in this format (yyyy-mm-dd) : ");
            releaseDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Number Of Tracks :");
            numOfTracks = Convert.ToInt32(Console.ReadLine());
            Song f = new Song(songName, singerName, releaseDate, numOfTracks);


            Console.WriteLine("\n_________________________");
            Console.WriteLine("Song Name :" + songName);
            Console.WriteLine("Singer Name :" + singerName);
            Console.WriteLine("Release Date :" + releaseDate);
            Console.WriteLine("Number Of Tracks :" + numOfTracks);
            Console.WriteLine("\n_________________________");
        }






    }
}
