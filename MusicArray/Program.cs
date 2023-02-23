using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace music
{
    class Program
    {
        enum Genre
        {
            Rock,
            Jazz,
            HipHop,
            Rap,
            HeavyMetal

        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string description, string length, string rating, Genre genre)
            {
                Title = title;
                Artist = description;
                Album = rating;
                Length = length;
                Genre = genre;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());

            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title?");
                    collection[i].setTitle(Console.ReadLine());



                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());


                    Console.WriteLine("What album is it on?");
                    collection[i].setAlbum(Console.ReadLine());


                    Console.WriteLine("What is the song length?");
                    collection[i].setLength(Console.ReadLine());


                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("A - Rock\nH - Jazz\nS - HipHop\nR - Rap\nD - Heavy Metal");
                    Genre tempGenre = Genre.Rock;
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'A':
                            tempGenre = Genre.Rock;
                            break;
                        case 'H':
                            tempGenre = Genre.Jazz;
                            break;
                        case 'S':
                            tempGenre = Genre.HipHop;
                            break;
                        case 'R':
                            tempGenre = Genre.Rap;
                            break;
                        case 'D':
                            tempGenre = Genre.HeavyMetal;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }


            finally
            {
                for(int i = 0; i< size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }

            }



          
        }
    }
}
