using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCensora
{
    public class CensoraClass
    {/// <summary>
     /// В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. В тексте может быть 0 или более слов "редиска", записанных в различном регистре.
     /// </summary>
     /// <param name="textString"></param>
     /// <returns>
     /// Возвращается отфильтрованный текст, в котором все слова редиска заменены на звездочки ***
     /// </returns>
        public static string Censore(string textString)
        {
            // Создаем список неприличных слов
            List<string> badWords = new List<string> {"редиска"};
            //Разбиваем текст на слова,
            string[] words = textString.Split();
            // Заменяем неприличные слова на звездочки
            for (int i = 0; i < words.Length; i++)
{
                if (badWords.Contains(words[i].ToLower()))
                {
                    words[i] = "***";
                }
            }
            string Text = string.Join(" ", words);

            return Text;
        }
    }
}
