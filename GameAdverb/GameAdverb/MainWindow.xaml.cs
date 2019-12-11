using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameAdverb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CsgoClick(object sender, RoutedEventArgs e)
        {
            string description = "Counter-Strike, также известная как Half-Life: Counter-Strike — многопользовательская компьютерная игра в жанре шутера от первого лица, разработанная и выпущенная для Microsoft Windows американской компанией Valve. Первоначально Counter-Strike представляла собой пользовательскую модификацию к игре Half-Life, разработанную энтузиастами Минем Ле и Джессом Клиффом в 1999 году; в дальнейшем Valve наняла обоих разработчиков на работу и приобрела у них права интеллектуальной собственности на игру, в 2000 году выпустив доработанную версию Counter-Strike уже как самостоятельную игру. Игра была в разные годы портирована на ряд платформ, в том числе macOS, Linux и Xbox.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://img.pngio.com/counter-strike-global-offensive-3-logo-png-transparent-svg-csgo-logo-transparent-2400_2400.png", "CS:GO", description, new DateTime(2012, 8, 21), 12.97, "Трёхмерный шутер с видом от первого лица", "https://img.esportnews.gg/pictures/content/29/29620_750.jpg", "1.36.9.2", "Майк Мораски", "многопользовательский"));
            viewWindow.Show();
        }

        private void DotaClick(object sender, RoutedEventArgs e)
        {
            string description = "Dota 2 — компьютерная многопользовательская командная игра в жанре multiplayer online battle arena, разработанная корпорацией Valve. Игра является продолжением DotA — пользовательской карты-модификации для игры Warcraft III: Reign of Chaos и дополнения к ней Warcraft III: The Frozen Throne. Игра изображает сражение на карте особого вида; в каждом матче участвуют две команды по пять игроков, управляющих «героями» — персонажами с различными наборами способностей. Для победы в матче команда должна уничтожить особый объект-«крепость», принадлежащий вражеской стороне, и защитить от уничтожения собственную «крепость». Dota 2 работает по модели free-to-play с элементами микроплатежей.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://spng.pngfind.com/pngs/s/77-774896_dota-2-logo-png-graphic-design-transparent-png.png", "Dota", description, new DateTime(2013, 7, 9), 0, "Трёхмерный шутер с видом от первого лица", "http://киберспорт.рф/wp-content/uploads/2019/09/%D0%91%D0%B5%D0%B7-%D0%B8%D0%BC%D0%B5%D0%BD%D0%B8-26.png", "1.36.9.2", "Майк Мораски", "многопользовательский"));
            viewWindow.Show();
        }

        private void MinecraftClick(object sender, RoutedEventArgs e)
        {
            string description = "Minecraft (от англ. mine «шахта; добывать» + craft «ремесло») — компьютерная инди-игра в жанре песочницы, разработанная шведским программистом Маркусом Перссоном и выпущенная его компанией Mojang AB. Перссон опубликовал начальную версию игры в 2009 году; в конце 2011 года была выпущена стабильная версия для ПК Microsoft Windows, распространявшаяся через официальный сайт. В последующие годы Minecraft была портирована на Linux и macOS для персональных компьютеров; на Android, iOS и Windows Phone для мобильных устройств; на игровые приставки PlayStation 4, Vita, VR, Xbox One, Nintendo 3DS, Switch и Wii U. В 2014 году Microsoft приобрела Mojang AB и права на Minecraft за $2,5 миллиарда. 4J Studios (англ.)русск. портировала игру на игровые приставки, а Xbox Game Studios разработала мультиплатформенную версию Minecraft и специальное издание игры для образовательных учреждений.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd6LxF5IwgC_9d4D9QMnvReoeL2EDpWAyZtVcw6xkeJlRAAOpjZw&s", "Minecraft", description, new DateTime(2011, 11, 18), 10, "симулятор выживания, action-adventure и открытый мир", "https://www.minecraft.net/content/dam/archive/og-image/minecraft-hero-og.jpg", "1.14.4", "Маркус Перссон", "одиночная игра и мультиплеер"));
            viewWindow.Show();
        }

        private void GtaVClick(object sender, RoutedEventArgs e)
        {
            string description = "Grand Theft Auto V (сокр. GTA V) — мультиплатформенная компьютерная игра в жанре action-adventure с открытым миром, разработанная компанией Rockstar North и изданная компанией Rockstar Games для игровых консолей PlayStation 3 и Xbox 360 в 2013 году. В последующие годы игра была выпущена на платформах Microsoft Windows, PlayStation 4 и Xbox One. Является пятнадцатой по счёту игрой серии Grand Theft Auto и следующей крупной игрой после Grand Theft Auto IV (2008)[4]. В России и СНГ издателем Grand Theft Auto V выступает компания 1С-СофтКлаб.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://www.vippng.com/png/detail/17-175538_gta-5-png-logo-v-gta-5-png.png", "GTA V", description, new DateTime(2015, 8, 14), 7, "	3D-шутер, экшен", "http://www.adriancourreges.com/img/blog/2015/gtav/a/gtav_logo.jpg", "1", "Род Эдж", "однопользовательский, многопользовательский"));
            viewWindow.Show();
        }

        private void RDRClick(object sender, RoutedEventArgs e)
        {
            string description = "Red Dead Redemption — приключенческий боевик-вестерн от третьего лица с открытым миром и элементами RPG. Разработана компанией Rockstar San Diego при поддержке Rockstar North, Rockstar NYC, Rockstar Leeds, Rockstar New England и Rockstar Lincoln. Выпущена 18 мая 2010 года на консоли PlayStation 3 и Xbox 360. Вторая игра серии Red Dead, является духовным наследником игры 2004 года — Red Dead Revolver.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://i.pinimg.com/originals/a2/29/7d/a2297d890d535a1d8cdb8b8adbfcdc2d.png", "Red Dead Redemption", description, new DateTime(2010, 5, 28), 80, "Шутер от третьего лица ", "https://cdn.mos.cms.futurecdn.net/geDmmMJ8YHFuGoxqJpgTcK-320-80.jpg", "1", "Стив Мартин", "однопользовательский, многопользовательский"));
            viewWindow.Show();
        }

        private void MetroClick(object sender, RoutedEventArgs e)
        {
            string description = "Dota 2 — компьютерная многопользовательская командная игра в жанре multiplayer online battle arena, разработанная корпорацией Valve. Игра является продолжением DotA — пользовательской карты-модификации для игры Warcraft III: Reign of Chaos и дополнения к ней Warcraft III: The Frozen Throne. Игра изображает сражение на карте особого вида; в каждом матче участвуют две команды по пять игроков, управляющих «героями» — персонажами с различными наборами способностей. Для победы в матче команда должна уничтожить особый объект-«крепость», принадлежащий вражеской стороне, и защитить от уничтожения собственную «крепость». Dota 2 работает по модели free-to-play с элементами микроплатежей.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://diskomir.ru/upload/iblock/2f8/2f8e16440069d237acabdc85cab8cad1.jpg", "Metro Exodus", description, new DateTime(2013, 7, 9), 30, "Шутер от первого лица", "https://cs8.pikabu.ru/post_img/big/2017/10/11/6/1507714838110898134.jpg", "1", "Андрей Прохоров", "однопользовательский"));
            viewWindow.Show();
        }

        private void SixSiegeClick(object sender, RoutedEventArgs e)
        {
            string description = "Tom Clancy’s Rainbow Six Siege (с англ. — «Радуга 6: Осада», в российской локализации известна как Tom Clancy’s Rainbow Six Осада) — тактический шутер от первого лица, разработанный Ubisoft для Microsoft Windows, Xbox One и PlayStation 4. Игра была анонсирована Ubisoft 9 июня 2014 на E3 и выпущена 1 декабря 2015 года. Проект стал преемником закрытого Patriots. В геймплее сделан упор на разрушаемость окружающей обстановки и тактическое взаимодействие игроков.";
            ViewWindow viewWindow = new ViewWindow(FillGame("http://www.dlf.pt/png/big/11/111832_rainbow-6-siege-logo-png.jpg", "Rainbow Six Siege", description, new DateTime(2015, 12, 1), 10, "Tактический шутер от первого лица", "https://s3.dexerto.com/thumbnails/_thumbnailLarge/six-siege-header.jpg", "1", "Саймон Ларойч", "oднопользовательский, многопользовательский"));
            viewWindow.Show();
        }

        private void CalofDutyClick(object sender, RoutedEventArgs e)
        {
            string description = "Call of Duty — серия компьютерных игр в жанре шутер от первого лица, посвящённых Второй мировой войне, холодной войне, борьбе с терроризмом, гипотетической Третьей мировой войне, войнам будущего и космическим войнам. Серия состоит из шестнадцати основных игр и десяти ответвлений.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://res.cloudinary.com/teepublic/image/private/s--ChC5igAR--/t_Resized%20Artwork/c_fit,g_north_west,h_954,w_954/co_000000,e_outline:48/co_000000,e_outline:inner_fill:48/co_ffffff,e_outline:48/co_ffffff,e_outline:inner_fill:48/co_bbbbbb,e_outline:3:1000/c_mpad,g_center,h_1260,w_1260/b_rgb:eeeeee/c_limit,f_jpg,h_630,q_90,w_630/v1568676112/production/designs/5981201_0.jpg", "Call of Duty: Modern Warfare", description, new DateTime(2019, 5, 30), 100, "Шутер от первого лица", "https://store-images.s-microsoft.com/image/apps.6548.64573185977183565.5d654c65-6a44-48df-aabb-f37569ffa45b.064ec65e-bd1a-4c80-80c0-8d3c83497327?mode=scale&q=90&h=1080&w=1920&format=jpg", "1", "Тейлор Куросаки", "однопользовательский, многопользовательский"));
            viewWindow.Show();
        }

        private void BattleClick(object sender, RoutedEventArgs e)
        {
            string description = "Battlefield (рус. Поле битвы) — серия компьютерных игр в жанре тактико-стратегического шутера от первого лица, разработанная шведской компанией EA Digital Illusions CE и издаваемая компанией Electronic Arts. Первая часть — «Battlefield 1942» — была выпущена в 2002 году и уже тогда получила широкую популярность. Серия особо популярна своим многопользовательским режимом, в котором могут принимать участие до 64 игроков, с выбором воюющей стороны, класса бойца с уникальным оружием, и возможностью управлять техникой на земле, на воде и в небе. За 10 лет существования в игры серии поиграло больше 50 млн человек.";
            ViewWindow viewWindow = new ViewWindow(FillGame("https://ih1.redbubble.net/image.568270217.4809/pp,650x642-pad,750x1000,f8f8f8.u1.jpg", "Battlefield V", description, new DateTime(2013, 7, 9), 0, "Шутер от первого лица", "https://i.ytimg.com/vi/QqVvR3gOKYA/maxresdefault.jpg", "1", "Йохан Содерквист", "однопользовательский, многопользовательский"));
            viewWindow.Show();
        }

        private Game FillGame(string logo, string name, string description, DateTime realise, double price, string genre, string image, string lastVersion, string creator, string modeGame)
        {
            return new Game(logo, name, description, realise, price, genre, image, lastVersion, creator, modeGame);
        }
    }
}
