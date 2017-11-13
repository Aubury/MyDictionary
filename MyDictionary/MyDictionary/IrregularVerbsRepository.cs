using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{ /// <summary>
  /// Класс-репозиторий получает откуда-либо фрагмент текста
  /// и преобразовывает его в массив массив.
  /// Обычно репозитарии работают с каким-либо хранилищем (БД, файл),
  /// но пока данные беруться из константы
  /// </summary>
    internal class IrregularVerbsRepository
    {
        private const string Data = @"be	was / were	been	быть \t
                                      beat	  beat	    beaten	бить \t
                                      become  became	become	становиться \t
                                      begin	  began	    begun	начинать  \t
                                      break	  broke	    broken	ломать  \t
                                      bring	  brought	brought	приносить  \t
                                      build	  built	    built	строить  \t
                                      burn	  burnt	    burnt	гореть  \t
                                      burst	  burst	    burst	взрываться \t
buy	bought	bought	покупать
can	could	-	мочь, уметь
catch	caught	caught	ловить, хватать
choose	chose	chosen	выбирать
come	came	come	приходить
cost	cost	cost	cтоить
cut	cut	cut	резать
do	did	done	делать
draw	drew	drawn	рисовать (карандашом)
drink	drank	drunk	пить
drive	drove	driven	водить (машину)
eat	ate	eaten	кушать, есть
fall	fell	fallen	падать
feel	felt	felt	чувствовать
fight	fought	fought	сражаться
find	found	found	находить
fly	flew	flown	летать
forget	forgot	forgotten	забывать
get	got	got	получать, становиться
give	gave	given	давать
go	went	gone	идти
grow	grew	grown	расти, выращивать
hang	hung	hung	висеть, вешать
have	had	had	иметь
hear	heard	heard	слышать
hide	hid	hidden	прятать
hit	hit	hit	ударять, попадать
hold	held	held	держать
hurt	hurt	hurt	причинять боль
keep	kept	kept	хранить; продолжать делать
know	knew	known	знать
learn	learnt	learnt	учить(-ся)
leave	left	left	уезжать, покидать
let	let	let	позволять
lie	lay	lain	лежать
lose	lost	lost	терять
make	made	made	делать, изготовлять
mean	meant	meant	иметь в виду
meet	met	met	встречать; знакомиться
pay	paid	paid	платить
prove	proved	proven	доказывать
put	put	put	класть, положить
read	read	read	читать
ring	rang	rung	звонить
run	ran	run	бегать
say	said	said	сказать
see	saw	seen	видеть
set	set	set	cтавить
sew	sewed	sewn	шить
sell	sold	sold	продавать
send	sent	sent	отправлять, посылать
shine	shone	shone	светить
show	showed	shown	показывать
shut	shut	shut	закрывать, захлопывать
sing	sang	sung	петь
sit	sat	sat	сидеть
sleep	slept	slept	спать
speak	spoke	spoken	говорить
spend	spent	spent	проводить (время)
spoil	spoilt	spoilt	портить
spread	spread	spread	расстилать
spring	sprang	sprung	прыгать
stand	stood	stood	стоять
steal	stole	stolen	красть, воровать
swim	swam	swum	плавать
take	took	taken	брать
teach	taught	taught	преподавать, учить
tell	told	told	сказать (кому-л.)
think	thought	thought	думать
throw	threw	thrown	бросать
understand	understood	understood	понимать
wake	woke	woken	просыпаться, будить
wear	wore	worn	носить (одежду)
weep	wept	wept	плакать
win	won	won	побеждать
write	wrote	written	писать";

        /// <summary>
        /// Разбивает текст на строки.
        /// Разделитель - символ перевода строки
        /// </summary>
        /// <returns>Массив строк</returns>
        private string[] GetRows(string Data)
        {
            return Data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Преобразует каждую строку в массив слов, разделенных симв. табуляции
        /// </summary>
        /// <returns>Массив массивов</returns>
        public string[][] GetWords(string Data)
        {
            var rows = GetRows(Data);
            string[][] words = new string[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                words[i] = rows[i].Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine(words[i]);
            }

            return words;
        }
     
    }
}

