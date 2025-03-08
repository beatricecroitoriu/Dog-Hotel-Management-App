using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class UserControlIntrebari : UserControl
    {
        public UserControlIntrebari()
        {
            InitializeComponent();
        }

        private void labelIntrebare1_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 1: \n \n        Desigur. Pentru toți cățeii există o primă dată. Asigură-te doar că animăluțul tău este deparazitat și vaccinat la zi, vaccinat inclusiv împotriva tusei de canisă.";
        }

        private void labelIntrebare2_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 2: \n \n        În principal, cățeii mănâncă de două ori pe zi, dimineața și seara. În cazul în care vreun cățel are un program special de masă sau un tratament medical, acesta este hrănit după indicațiile proprietarului.";
        }

        private void labelIntrebare3_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 3: \n \n        Check-in-ul se face la orice oră în timpul programului cu publicul. \n Luni - Vineri: 10:00 - 19:00 \n Sâmbătă - Duminică: 11:00 - 17:00";
        }

        private void labelIntrebare4_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 4: \n \n        Check-out-ul se face până la ora 13:00. Dacă se depășește această oră, se anunță în prealabil cu minim 24h înainte de check-out.";
        }

        private void labelIntrebare5_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 5: \n \n        Cățeii cazați la Dog Hotel sunt scoși afară de minim 3 ori pe zi. În medie, ies afară cam de 5 ori pe zi, între 15 – 45 min., pe grupe, în funcție de vreme și de cum se înțeleg cu ceilalți căței cazați.";
        }

        private void labelIntrabare6_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 6: \n \n        Preferăm căței sociabili între ei, dar dacă nu e sociabil cu alți căței nu e nicio problemă. Va ieși separat afară să alerge și să se joace cu noi.";
        }

        private void labelIntrebare7_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 7: \n \n        Cățelul trebuie să aibă împlinite minim 3 luni până la ziua cazării acestuia.";
        }

        private void labelIntrebare8_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 8: \n \n        Avem un număr mare de pături și coșuri, pe care le spălăm și dezinfectăm permanent, așa că nu este nevoie de pături, saltele sau paturi plate, în special textile sau saltele umplute cu vată, care în cele mai multe cazuri vor fi ciugulite.\r\nAvem boluri și suporturi din oțel inoxidabil pentru câini de talie mare, toate curățate și dezinfectate după fiecare check-out.\r\nPrin urmare, nu credem că este necesar să aduceți niciunul. Încercăm să vă facem lucrurile cât mai ușor, așa că este bine să renunțați la bagajele care nu sunt neapărat necesare.\r\n";
        }

        private void labelIntrebare9_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 9: \n \n        La Dog Hotel sunt angajați care stau de serviciu 24/24 ore, 7/7 zile, dar nu stau cu prietenul tău în aceeași cameră sau cu țarcuri în aer liber, însă animalul tău de companie este supravegheat video de către angajați, in timp real. Pentru a respecta orele de odihnă ale cățeilor și pentru a nu-i împiedica să doarmă, angajații se plimbă cât mai puțin între orele 23:00-6:00.";
        }

        private void labelIntrebare10_Click(object sender, EventArgs e)
        {
            labelRaspuns.Text = "     Răspuns întrebarea 10: \n \n       Bineînțeles că puteți, dar permitem doar până la 2 jucării necomestibile care trebuie să fie noi sau întregi, fără piese lipsă. În caz contrar, vom presupune că animalul dvs. de companie a înghițit piese de jucărie și va trebui să chemăm ambulanța veterinară, serviciu pentru care va trebui să plătiți.\r\nDacă animăluțul tău iese cu jucării în locurile de joacă, se pot încurca cu jucăriile altor căței, așa că te rugăm să verifici existența lor la check-out.\r\n";
        }

    }
}
