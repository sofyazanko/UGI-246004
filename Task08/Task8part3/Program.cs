using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var whiteRookPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черной ладьи");
            var blackRookPosition = Console.ReadLine();

            if (whiteRookPosition == blackRookPosition)
            {
                Console.WriteLine("Ладьи не могут стоять на одной клетке");
                return;
            }
            int whiteRookH, whiteRookV;
            int blackRookH, blackRookV;

            DecodePosition(whiteRookPosition, out whiteRookV, out whiteRookH);//вызывается для преобр в числовые координаты
            DecodePosition(blackRookPosition, out blackRookV, out blackRookH);

            if (whiteRookH < 1 || whiteRookH > 8 || whiteRookV < 1 || whiteRookV > 8 ||
              blackRookH < 1 ||  blackRookH > 8 || blackRookV < 1 || blackRookV > 8)

            {
                Console.WriteLine("Ошибка! Координаты фигур выходят за пределы шахматной доски.");
                    return;
            }    

            if (IsUnderStrikeByBlackRook(whiteRookPosition, blackRookPosition) ||
               IsUnderStrikeByWhiteRook(blackRookPosition, whiteRookPosition))
                Console.WriteLine("Ладьи бьют друг друга");
            else
                Console.WriteLine("Ладьи не бьют друг друга");
        }
        static void DecodePosition(string position, out int vert, out int hor)

        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());
        }
        static bool IsUnderStrikeByWhiteRook(string position, string whiteRookPostition)
        {
            int pV, pH, wrV, wrH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(whiteRookPostition, out wrV, out wrH);

            return pV == wrV || pH == wrH;

        }
        static bool IsUnderStrikeByBlackRook(string position, string blackRookPostition)
        {
            int pV, pH, brV, brH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(blackRookPostition, out brV, out brH);

            return pV == brV || pH == brH;
        }

    }

}
