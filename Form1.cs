using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Periodic_Table_go
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }


        public void jogaprala(String Nome, String numero, String massa, String img, String simbolo)
        {
            Elemento tela2  = new Elemento();
            distributiva.nome = Nome;
            distributiva.numAtomico = numero;
            distributiva.endImagem = img;
            distributiva.numMassa = massa;
            distributiva.simbolo = simbolo;
            tela2.Show();




        }

        private void h1_Click(object sender, EventArgs e)
        {
            jogaprala("Hidrogênio", "1", "1,001", @"elementos\h1.jpg", "H");
        }

        private void li2_Click(object sender, EventArgs e)
        {
            jogaprala("Litio", "3", "7", "li", @"elementos\Li.jpg");
        }

        private void na3_Click(object sender, EventArgs e)
        {
            jogaprala("Sódio", "11", "23", @"elementos\Na.jpg", "Na");
        }

        private void k4_Click(object sender, EventArgs e)
        {
            jogaprala("Potássio", "19", "39", @"elementos\K.jpg", "K");
        }

        private void rb5_Click(object sender, EventArgs e)
        {
            jogaprala("Rubpidio", "37", "85", @"elementos\Rb.jpg", "Rb");
        }

        private void cs6_Click(object sender, EventArgs e)
        {
            jogaprala("Césio", "55", "132", @"elementos\cs.jpg", "Cs");
        }

        private void fr7_Click(object sender, EventArgs e)
        {
            jogaprala("Frâmcio", "87", "223", @"elementos\Fr.jpg", "Fr");
        }

        private void be8_Click(object sender, EventArgs e)
        {
            jogaprala("Berílio", "4", "9", @"elementos\be.jpg", "Be");
        }

        private void mg9_Click(object sender, EventArgs e)
        {
            jogaprala("magnésio", "12", "9", @"elementos\Mg.jpg", "Mg");
        }

        private void ca10_Click(object sender, EventArgs e)
        {
            jogaprala("Cálcio", "20", "40", @"elementos\CA.jpg", "Ca");
        }

        private void sr11_Click(object sender, EventArgs e)
        {
            jogaprala("Estrôncio", "38", "87", @"elementos\sr.jpg", "Sr");
        }

        private void ba12_Click(object sender, EventArgs e)
        {
            jogaprala("Bário", "56", "137", @"elementos\ba.jpg", "Ba");
        }

        private void ra13_Click(object sender, EventArgs e)
        {
            jogaprala("Rádio", "88", "226", @"elementos\ra.jpg", "Ra");
        }

        private void sc14_Click(object sender, EventArgs e)
        {
            jogaprala("Escandio", "21", "45", @"elementos\sc.jpg", "Sc");
        }

        private void y15_Click(object sender, EventArgs e)
        {
            jogaprala("Ítrio", "39", "88", @"elementos\y.jpg", "Y");
        }

        private void ti16_Click(object sender, EventArgs e)
        {
            jogaprala("Ti", "22", "47", @"elementos\ti.jpg", "Ti");
        }

        private void zr17_Click(object sender, EventArgs e)
        {
            jogaprala("Zircônio", "40", "91", @"elementos\zr.jpg", "Zr");
        }

        private void hf18_Click(object sender, EventArgs e)
        {
            jogaprala("Háfnio", "72", "178", @"elementos\hf.jpg", "Hf");
        }

        private void rf19_Click(object sender, EventArgs e)
        {
            jogaprala("Rutherfórdio", "104", "261", @"elementos\rf.jpg", "Rf");
        }

        private void v20_Click(object sender, EventArgs e)
        {
            jogaprala("V", "23", "50", @"elementos\v.jpg", "V");
        }

        private void nb21_Click(object sender, EventArgs e)
        {
            jogaprala("Niórbio", "41", "92", @"elementos\nb.jpg", "Nb");
        }

        private void ta22_Click(object sender, EventArgs e)
        {
            jogaprala("Tântalo", "73", "180", @"elementos\ta.jpg", "Ta");
        }

        private void db23_Click(object sender, EventArgs e)
        {
            jogaprala("Dúbnio", "105", "262", @"elementos\db.jpg", "Db");
        }

        private void cr24_Click(object sender, EventArgs e)
        {
            jogaprala("Cromo", "24", "51", @"elementos\cr.jpg", "CR");
        }

        private void mo25_Click(object sender, EventArgs e)
        {
            jogaprala("Molidêbdênio", "42", "95", @"elementos\mo.jpg", "Mo");
        }

        private void w26_Click(object sender, EventArgs e)
        {
            jogaprala("Tugstênio", "74", "183", @"elementos\w.jpg", "W");
        }

        private void sg27_Click(object sender, EventArgs e)
        {
            jogaprala("Seabórgio", "106", "266", @"elementos\sg.jpg", "Sg");
        }

        private void mn28_Click(object sender, EventArgs e)
        {
            jogaprala("Manganês", "25", "54", @"elementos\mn.jpg", "Mn");
        }

        private void tc29_Click(object sender, EventArgs e)
        {
            jogaprala("Tecnécio", "43", "98", @"elementos\tc.jpg", "Tc");
        }

        private void re30_Click(object sender, EventArgs e)
        {
            jogaprala("Rênio", "75", "186", @"elementos\re.jpg", "Re");
        }

        private void bh31_Click(object sender, EventArgs e)
        {
            jogaprala("Bóhrio", "107", "264", @"elementos\bh.jpg", "Bh");
        }

        private void fe32_Click(object sender, EventArgs e)
        {
            jogaprala("Ferro", "26", "55", @"elementos\fe.jpg", "Fe");
        }

        private void ru33_Click(object sender, EventArgs e)
        {
            jogaprala("Rutênio", "44", "101", @"elementos\ru.jpg", "Ru");
        }

        private void os34_Click(object sender, EventArgs e)
        {
            jogaprala("Ósmio", "76", "190", @"elementos\os.jpg", "Os");
        }

        private void hs35_Click(object sender, EventArgs e)
        {
            jogaprala("Hássio", "108", "277", @"elementos\hs.jpg", "Hs");
        }

        private void co36_Click(object sender, EventArgs e)
        {
            jogaprala("Cobalto", "27", "58", @"elementos\co.jpg", "Co");
        }

        private void rh37_Click(object sender, EventArgs e)
        {
            jogaprala("Ródio", "45", "102", @"elementos\rh.jpg", "Rh");
        }

        private void ir38_Click(object sender, EventArgs e)
        {
            jogaprala("Irídio", "77", "192", @"elementos\ir.jpg", "Ir");
        }

        private void mt39_Click(object sender, EventArgs e)
        {
            jogaprala("Mitnério", "28", "58", @"elementos\mt.jpg", "Mt");
        }

        private void ni40_Click(object sender, EventArgs e)
        {
            jogaprala("Níquel", "46", "106", @"elementos\ni.jpg", "NI");
        }

        private void pd41_Click(object sender, EventArgs e)
        {
            jogaprala("Paládio", "78", "195", @"elementos\pd.jpg", "Pd");
        }

        private void pt42_Click(object sender, EventArgs e)
        {
            jogaprala("Platina", "110", "227", @"elementos\pt.jpg", "Pt");
        }

        private void ds43_Click(object sender, EventArgs e)
        {
            jogaprala("Darmstádio", "29", "63", @"elementos\ds.jpg", "Ds");
        }

        private void cu44_Click(object sender, EventArgs e)
        {
            jogaprala("Cobre", "47", "107", @"elementos\cu.jpg", "Cu");
        }

        private void ag45_Click(object sender, EventArgs e)
        {
            jogaprala("Prata", "79", "196", @"elementos\ag.jpg", "Ag");
        }

        private void au46_Click(object sender, EventArgs e)
        {
            jogaprala("Ouro", "111", "272", @"elementos\au.jpg", "Au");
        }

        private void rg47_Click(object sender, EventArgs e)
        {
            jogaprala("Roentgênio", "30", "65", @"elementos\rg.jpg", "Rg");
        }

        private void zn48_Click(object sender, EventArgs e)
        {
            jogaprala("Zinco", "48", "112", @"elementos\zn.jpg", "Zn");
        }

        private void cd49_Click(object sender, EventArgs e)
        {
            jogaprala("Cádmio", "80", "200", @"elementos\cd.jpg", "Cd");
        }

        private void hg50_Click(object sender, EventArgs e)
        {
            jogaprala("Mercúrio", "112", "277", @"elementos\hg.jpg", "Hg");
        }

        private void cn51_Click(object sender, EventArgs e)
        {
            jogaprala("Copernício", "5", "10", @"elementos\cn.jpg", "Cn");
        }

        private void b52_Click(object sender, EventArgs e)
        {
            jogaprala("Boro", "13", "26", @"elementos\mt.jpg", "B");
        }

        private void al53_Click(object sender, EventArgs e)
        {
            jogaprala("Alumínio", "31", "69", @"elementos\al.jpg", "Al");
        }

        private void ga54_Click(object sender, EventArgs e)
        {
            jogaprala("Gálo", "49", "114", @"elementos\ga.jpg", "Ga");
        }

        private void in55_Click(object sender, EventArgs e)
        {
            jogaprala("Índio", "81", "204", @"elementos\in.jpg", "In");
        }

        private void ti56_Click(object sender, EventArgs e)
        {
            jogaprala("Tálio", "113", "286", @"elementos\ti.jpg", "Ti");
        }

        private void nh57_Click(object sender, EventArgs e)
        {
            jogaprala("Nihônio", "113", "12", @"elementos\nh.jpg", "Nh");
        }

        private void c58_Click(object sender, EventArgs e)
        {
            jogaprala("Caborno", "6", "28", @"elementos\c.jpg", "C");
        }

        private void si59_Click(object sender, EventArgs e)
        {
            jogaprala("Silício", "14", "72", @"elementos\si.jpg", "Si");
        }

        private void ge60_Click(object sender, EventArgs e)
        {
            jogaprala("Gesmânio", "32", "118", @"elementos\ge.jpg", "Ge");
        }

        private void sn61_Click(object sender, EventArgs e)
        {
            jogaprala("Estanho", "50", "207", @"elementos\sn.jpg", "Sn");
        }

        private void pd62_Click(object sender, EventArgs e)
        {
            jogaprala("Chumbo", "82", "289", @"elementos\pd.jpg", "Pd");
        }

        private void fl63_Click(object sender, EventArgs e)
        {
            jogaprala("Fleróvio", "114", "14", @"elementos\fl.jpg", "Fl");
        }

        private void n64_Click(object sender, EventArgs e)
        {
            jogaprala("Nitrogênio", "7", "30", @"elementos\n.jpg", "N");
        }

        private void p65_Click(object sender, EventArgs e)
        {
            jogaprala("Fósforo", "15", "74", @"elementos\p.jpg", "P");
        }

        private void as66_Click(object sender, EventArgs e)
        {
            jogaprala("Arsênio", "33", "121", @"elementos\as.jpg", "As");
        }

        private void sb67_Click(object sender, EventArgs e)
        {
            jogaprala("Antimônio", "51", "208", @"elementos\sb.jpg", "Sb");
        }

        private void bi68_Click(object sender, EventArgs e)
        {
            jogaprala("Bismuto", "83", "288", @"elementos\bi.jpg", "Bi");
        }

        private void mc69_Click(object sender, EventArgs e)
        {
            jogaprala("Moscóvio", "115", "15", @"elementos\mc.jpg", "Mc");
        }

        private void o70_Click(object sender, EventArgs e)
        {
            jogaprala("Oxigênio", "8", "32", @"elementos\o.jpg", "O");
        }

        private void s71_Click(object sender, EventArgs e)
        {
            jogaprala("Enxofre", "16", "78", @"elementos\s.jpg", "S");
        }

        private void se71_Click(object sender, EventArgs e)
        {
            jogaprala("Selênio", "34", "128", @"elementos\se.jpg", "Se");
        }

        private void te73_Click(object sender, EventArgs e)
        {
            jogaprala("Telúrio", "52", "210", @"elementos\te.jpg", "Te");
        }

        private void po74_Click(object sender, EventArgs e)
        {
            jogaprala("Polônio", "116", "293", @"elementos\po.jpg", "Po");
        }

        private void lv75_Click(object sender, EventArgs e)
        {
            jogaprala("Livermório", "116", "4", @"elementos\lv.jpg", "Lv");
        }

        private void f76_Click(object sender, EventArgs e)
        {
            jogaprala("Flúor", "9", "20", @"elementos\f.jpg", "F");
        }

        private void cl77_Click(object sender, EventArgs e)
        {
            jogaprala("Cloro", "17", "39", @"elementos\cl.jpg", "Cl");
        }

        private void br78_Click(object sender, EventArgs e)
        {
            jogaprala("Bromo", "35", "83", @"elementos\br.jpg", "Br");
        }

        private void i79_Click(object sender, EventArgs e)
        {
            jogaprala("Iodo", "53", "131", @"elementos\i.jpg", "I");
        }

        private void at80_Click(object sender, EventArgs e)
        {
            jogaprala("Ástato", "85", "220", @"elementos\at.jpg", "At");
        }

        private void ts81_Click(object sender, EventArgs e)
        {
            jogaprala("Tenessino", "117", "294", @"elementos\ts.jpg", "Ts");
        }

        private void he82_Click(object sender, EventArgs e)
        {
            jogaprala("Hélio", "2", "4", @"elementos\he.jpg", "He");
        }

        private void ne83_Click(object sender, EventArgs e)
        {
            jogaprala("Neônio", "10", "20", @"elementos\ne.jpg", "Ne");
        }

        private void ar84_Click(object sender, EventArgs e)
        {
            jogaprala("Argônio", "18", "39", @"elementos\ar.jpg", "Ar");
        }

        private void kr85_Click(object sender, EventArgs e)
        {
            jogaprala("Criptônio", "36", "83", @"elementos\kr.jpg", "Kr");
        }

        private void xe86_Click(object sender, EventArgs e)
        {
            jogaprala("Xenônio", "54", "131", @"elementos\xe.jpg", "Xe");
        }

        private void rn87_Click(object sender, EventArgs e)
        {
            jogaprala("Radônio", "86", "220", @"elementos\rn.jpg", "Rn");
        }

        private void ob88_Click(object sender, EventArgs e)
        {
            jogaprala("Oganessônio", "118", "294", @"elementos\ob.jpg", "Og");
        }

        private void la89_Click(object sender, EventArgs e)
        {
            jogaprala("Lantânio", "57", "138", @"elementos\la.jpg", "La");
        }

        private void ce90_Click(object sender, EventArgs e)
        {
            jogaprala("Cério", "58", "140", @"elementos\ce.jpg", "Ce");
        }

        private void pr91_Click(object sender, EventArgs e)
        {
            jogaprala("Praseodímio", "59", "140", @"elementos\pr.jpg", "");
        }

        private void nd92_Click(object sender, EventArgs e)
        {
            jogaprala("Neodímo", "60", "144", @"elementos\nd.jpg", "Nd");
        }

        private void pm93_Click(object sender, EventArgs e)
        {
            jogaprala("Promécio", "61", "145", @"elementos\pm.jpg", "Pm");
        }

        private void sm94_Click(object sender, EventArgs e)
        {
            jogaprala("Samário", "62", "150", @"elementos\sm.jpg", "Sm");
        }

        private void eu95_Click(object sender, EventArgs e)
        {
            jogaprala("Európio", "63", "151", @"elementos\eu.jpg", "Eu");
        }

        private void gd96_Click(object sender, EventArgs e)
        {
            jogaprala("Gadolínio", "64", "157", @"elementos\gd.jpg", "Gd");
        }

        private void tb97_Click(object sender, EventArgs e)
        {
            jogaprala("Térbio", "65", "158", @"elementos\tb.jpg", "Tb");
        }

        private void dy98_Click(object sender, EventArgs e)
        {
            jogaprala("Disprósio", "66", "162", @"elementos\dy.jpg", "Dy");
        }

        private void ho99_Click(object sender, EventArgs e)
        {
            jogaprala("Hólmio", "67", "164", @"elementos\ho.jpg", "Ho");
        }

        private void er100_Click(object sender, EventArgs e)
        {
            jogaprala("Érbio", "68", "167", @"elementos\er.jpg", "Er);
        }

        private void tm101_Click(object sender, EventArgs e)
        {
            jogaprala("Tulio", "69", "168", @"elementos\tm.jpg", "Tm");
        }

        private void yb102_Click(object sender, EventArgs e)
        {
            jogaprala("Itébio", "70", "173", @"elementos\yb.jpg", "Yb");
        }

        private void lu103_Click(object sender, EventArgs e)
        {
            jogaprala("Lutécio", "71", "174", @"elementos\lu.jpg", "Lu");
        }

        private void ac104_Click(object sender, EventArgs e)
        {
            jogaprala("Actínio", "89", "227", @"elementos\ac.jpg", "Ac");
        }

        private void th105_Click(object sender, EventArgs e)
        {
            jogaprala("Tório", "90", "232", @"elementos\th.jpg", "Th");
        }

        private void pa106_Click(object sender, EventArgs e)
        {
            jogaprala("Protactínio", "91", "231", @"elementos\pa.jpg", "Pa");
        }

        private void u107_Click(object sender, EventArgs e)
        {
            jogaprala("Urânio", "92", "238", @"elementos\u.jpg", "U");
        }

        private void np108_Click(object sender, EventArgs e)
        {
            jogaprala("Netúnio", "93", "237", @"elementos\np.jpg", "Np");
        }

        private void pu109_Click(object sender, EventArgs e)
        {
            jogaprala("Plutônio", "244", "94", @"elementos\pu.jpg", "Pu");
        }

        private void am110_Click(object sender, EventArgs e)
        {
            jogaprala("Ameríco", "95", "243", @"elementos\am.jpg", "Am");
        }

        private void cm111_Click(object sender, EventArgs e)
        {
            jogaprala("Cúrio", "96", "247", @"elementos\cm.jpg", "Cm");
        }

        private void bk112_Click(object sender, EventArgs e)
        {
            jogaprala("Berquélio", "97", "247", @"elementos\bk.jpg", "Bk");
        }

        private void cf113_Click(object sender, EventArgs e)
        {
            jogaprala("Califórnio", "98", "251", @"elementos\cf.jpg", "Cf");
        }
        private void es114_Click(object sender, EventArgs e)
        {
            jogaprala("Eisténio", "99", "252", @"elementos\es.jpg", "Es");
        }

        private void fm115_Click(object sender, EventArgs e)
        {
            jogaprala("Férmio", "100", "257", @"elementos\fm.jpg", "Fm");
        }

        private void md116_Click(object sender, EventArgs e)
        {
            jogaprala("Mendelévio", "101", "258", @"elementos\md.jpg", "Md");
        }

        private void no117_Click(object sender, EventArgs e)
        {
            jogaprala("Nobélio", "102", "259", @"elementos\no.jpg", "No");
        }

        private void lr118_Click(object sender, EventArgs e)
        {
            jogaprala("Laurêncio", "103", "262", @"elementos\lr.jpg", "Lr");
        }
    }
}
