using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sistema : MonoBehaviour {
    public Canvas System, quitmenu;
    public Button Quit, Play, mapV, mapC, mapF, casaQ, casaP, quartinM, quartinV,quartinD, Vfloresta, Nfloresta , flor0, flor1, flor2,
        flor3, flor4, flor5,VFNorte,BPedras,BPedraV;
    public Image backMenu, backMap, backCasa, backQuartinho, casaMesa, BackMortal, BackFloresta, BackFlorestaNorte, backPedras, 
	backDestila, backexplosion;

    public int[] Bag, Baga, igredientes, Bagb, Bagc;

	public float contandotempo;

    // botoes mortal//

    public Button usar, b0, b01, b02, b03, b04, b05, voltaru, voltarQ,
        i0, i01, i02, i03, i04, i05,
        plus1, less1;
    public int b0n, b0nb, b0nc, b01n, b01nb, b01nc, b02n, b02nb, b02nc, somaRU, a;
    public bool somaR;

	//Botoes destila
	public Button DS, DD, DT, DC, P0, P1, P2, P3, P4, P5, BvoltarDP, BvoltarDD, BF,BvoltarDC;
	public Text texto;

	//Botoes Mina
	public Button firsten, BVoltarEXPLOSION;
	public int countMF;


    
    void Start() {
        DontDestroyOnLoad(transform.gameObject);
        somaR = false;
		igredientes = new int[9];
        Bag = new int[9];
        Baga = new int[9];
		Bagb = new int[9];

		countMF = 10;
		 

		//organizar backgrounds
		backMenu.enabled=true;
		Play.enabled = true;
		Play.image.enabled = true;
		Quit.enabled = true;
		Quit.image.enabled = true;




    }

    public void BquartinM()
    {

        quartinM.enabled = false;
        quartinM.image.enabled = false;
        quartinV.enabled = false;
        quartinV.image.enabled = false;
        backQuartinho.enabled = false;
        quartinD.enabled = false;
        quartinD.image.enabled = false;

        BackMortal.enabled = true;
        usar.enabled = true;
        usar.image.enabled = true;
        voltarQ.enabled = true;
        voltarQ.image.enabled = true;
    }
    public void BquartinV()
    {
        backCasa.enabled = true;
        backQuartinho.enabled = false;
        casaMesa.enabled = true;
        casaP.enabled = true;
        casaP.image.enabled = true;
        casaQ.enabled = true;
        casaQ.image.enabled = true;

        quartinM.enabled = false;
        quartinM.image.enabled = false;
        quartinV.enabled = false;
        quartinV.image.enabled = false;
        quartinD.enabled = false;
        quartinD.image.enabled = false;
    }
    public void BquartinD()
    {
		backDestila.enabled = true;
		DS.enabled = true;
		DS.image.enabled = true;
		DD.enabled = true;
		DD.image.enabled = true;
		DT.enabled = true;
		DT.image.enabled = true;
		DC.enabled = true;
		DC.image.enabled = true;
		BvoltarDD.enabled = true;
		BvoltarDD.image.enabled = true;

		backQuartinho.enabled = false;
		quartinM.enabled = false;
		quartinM.image.enabled = false;
		quartinV.enabled = false;
		quartinV.image.enabled = false;
		backQuartinho.enabled = false;
		quartinD.enabled = false;
		quartinD.image.enabled = false;


    }
	//destila simples
	public void BdestilaS()
	{
		DS.enabled = false;
		DS.image.enabled = false;
		DD.enabled = false;
		DD.image.enabled = false;
		DT.enabled = false;
		DT.image.enabled = false;
		DC.enabled = false;
		DC.image.enabled = false;
		BvoltarDD.enabled = false;
		BvoltarDD.image.enabled = false;

		P0.enabled = true;
		P0.image.enabled = true;
		P1.enabled = true;
		P1.image.enabled = true;
		P2.enabled = true;
		P2.image.enabled = true;
		P3.enabled = true;
		P3.image.enabled = true;
		P4.enabled = true;
		P4.image.enabled = true;
		P5.enabled = true;
		P5.image.enabled = true;
		BvoltarDP.enabled = true;
		BvoltarDP.image.enabled = true;


	}
	public void BdestilaC()
	{
		DS.enabled = false;
		DS.image.enabled = false;
		DD.enabled = false;
		DD.image.enabled = false;
		DT.enabled = false;
		DT.image.enabled = false;
		DC.enabled = false;
		DC.image.enabled = false;
		BvoltarDD.enabled = false;
		BvoltarDD.image.enabled = false;


		BvoltarDC.enabled = true;
		BvoltarDC.image.enabled = true;
		BF.enabled = true;
		BF.image.enabled = true;

	}
	public void BdestilaCBombaF()
	{
		if (Bagb [0] >= 1 && Bagb [1] >= 1) 
		{
			Bagb [0] -= 1;
			Bagb [1] -= 1;
			Bagc [0] += 1;
		}

	}
	public void BVoltarDC ()
	{
		DS.enabled = true;
		DS.image.enabled = true;
		DD.enabled = true;
		DD.image.enabled = true;
		DT.enabled = true;
		DT.image.enabled = true;
		DC.enabled = true;
		DC.image.enabled = true;
		BvoltarDD.enabled = true;
		BvoltarDD.image.enabled = true;

		BF.enabled = false;
		BF.image.enabled = false;
		BvoltarDC.enabled = false;
		BvoltarDC.image.enabled = false;
	}
	public void BdestilaVP()
	{
		BvoltarDP.enabled = false;
		BvoltarDP.image.enabled = false;
		P0.enabled = false;
		P0.image.enabled = false;
		P1.enabled = false;
		P1.image.enabled = false;
		P2.enabled = false;
		P2.image.enabled = false;
		P3.enabled = false;
		P3.image.enabled = false;
		P4.enabled = false;
		P4.image.enabled = false;
		P5.enabled = false;
		P5.image.enabled = false;

		DS.enabled = true;
		DS.image.enabled = true;
		DD.enabled = true;
		DD.image.enabled = true;
		DT.enabled = true;
		DT.image.enabled = true;
		DC.enabled = true;
		DC.image.enabled = true;
		BvoltarDD.enabled = true;
		BvoltarDD.image.enabled = true;

	}
	public void BdestilaVD()
	{
		


		backQuartinho.enabled = true;
		quartinM.enabled = true;
		quartinM.image.enabled = true;
		quartinV.enabled = true;
		quartinV.image.enabled = true;
		quartinD.enabled = true;
		quartinD.image.enabled = true;

		DS.enabled = false;
		DS.image.enabled = false;
		DD.enabled = false;
		DD.image.enabled = false;
		DT.enabled = false;
		DT.image.enabled = false;
		DC.enabled = false;
		DC.image.enabled = false;
		BvoltarDD.enabled = false;
		BvoltarDD.image.enabled = false;
		backDestila.enabled = false;
	}
	//criar pot

	public void BpotA()
	{
		
		if (Bag [0] >= 1)
		{
			Bag [0] -= 1;
			Baga [0] += 1;
			texto.text = "PoçãoA :" + Baga[0];
			texto.enabled = true;
			contandotempo = 1;

		}
	}

	public void BpotB()
	{

		if (Bag [1] >= 1)
		{
			Bag [1] -= 1;
			Baga [1] += 1;
			texto.text = "PoçãoB :" + Baga[1];
			texto.enabled = true;
			contandotempo = 1;

		}
	}
	public void BpotC()
	{

		if (Bag [2] >= 1)
		{
			Bag [2] -= 1;
			Baga [2] += 1;
			texto.text = "PoçãoC :" + Baga[2];
			texto.enabled = true;
			contandotempo = 1;

		}
	}
	public void BpotD()
	{

		if (Bag [3] >= 1)
		{
			Bag [3] -= 1;
			Baga [3] += 1;
			texto.text = "PoçãoD :" + Baga[3];
			texto.enabled = true;
			contandotempo = 1;

		}
	}
	public void BpotE()
	{

		if (Bag [4] >= 1)
		{
			Bag [4] -= 1;
			Baga [4] += 1;
			texto.text = "PoçãoE :" + Baga[4];
			texto.enabled = true;
			contandotempo = 1;

		}
	}
	public void BpotF()
	{

		if (Bag [5] >= 1)
		{
			Bag [5] -= 1;
			Baga [5] += 1;
			texto.text = "PoçãoF :" + Baga[5];
			texto.enabled = true;
			contandotempo = 1;

		}
	}

	//casa
    public void BcasaQ()
    {
        backCasa.enabled = false;
        backQuartinho.enabled = true;
        casaMesa.enabled = false;
        casaP.enabled = false;
        casaP.image.enabled = false;
        casaQ.enabled = false;
        casaQ.image.enabled = false;

        quartinM.enabled = true;
        quartinM.image.enabled = true;
        quartinV.enabled = true;
        quartinV.image.enabled = true;
        quartinD.enabled = true;
        quartinD.image.enabled = true;
    }
    public void VcasaP()
    {
        backCasa.enabled = false;
        casaMesa.enabled = false;
        casaP.enabled = false;
        casaP.image.enabled = false;
        casaQ.enabled = false;
        casaQ.image.enabled = false;

        backMap.enabled = true;
        mapV.enabled = true;
        mapV.image.enabled = true;
        mapC.enabled = true;
        mapC.image.enabled = true;
        mapF.enabled = true;
        mapF.image.enabled = true;
		BPedras.enabled = true;
		BPedras.image.enabled = true;
    }
    //floresta sul voltar
    public void Fvoltar()
    {
        BackFloresta.enabled = false;
        Vfloresta.enabled = false;
        Vfloresta.image.enabled = false;
        flor0.enabled = false;
        flor0.image.enabled = false;
        flor1.enabled = false;
        flor1.image.enabled = false;
        flor2.enabled = false;
        flor2.image.enabled = false;
        Nfloresta.enabled = false;
        Nfloresta.image.enabled = false;

        backMap.enabled = true;
        mapV.enabled = true;
        mapV.image.enabled = true;
        mapC.enabled = true;
        mapC.image.enabled = true;
        mapF.enabled = true;
        mapF.image.enabled = true;
		BPedras.enabled = true;
		BPedras.image.enabled = true;
    }
	//floresta norte entrar
	public void FNEntrar()
	{
		BackFloresta.enabled = false;
		Vfloresta.enabled = false;
		Vfloresta.image.enabled = false;
		flor0.enabled = false;
		flor0.image.enabled = false;
		flor1.enabled = false;
		flor1.image.enabled = false;
		flor2.enabled = false;
		flor2.image.enabled = false;
		Nfloresta.enabled = false;
		Nfloresta.image.enabled = false;

		BackFlorestaNorte.enabled = true;
		flor3.enabled = true;
		flor3.image.enabled = true;
		flor4.enabled = true;
		flor4.image.enabled = true;
		flor5.enabled = true;
		flor5.image.enabled = true;
		VFNorte.enabled = true;
		VFNorte.image.enabled = true;


	}
	//floresta sul
    public void Flor00()
        {
        igredientes[0] += 1;
        }
    public void Flor01()
    {
        igredientes[1] += 1;
    }
    public void Flor02()
    {
        igredientes[2] += 1;
    }
    
    //floresta norte
    public void Flor03()
    {
        igredientes[3] += 1;
    }
    public void Flor04()
    {
        igredientes[4] += 1;
    }
    public void Flor05()
    {
        igredientes[5] += 1;
    }
	//floresta norte voltar
    public void VFN()
    {
        BackFloresta.enabled = true;
        Vfloresta.enabled = true;
        Vfloresta.image.enabled = true;
        flor0.enabled = true;
        flor0.image.enabled = true;
        flor1.enabled = true;
        flor1.image.enabled = true;
        flor2.enabled = true;
        flor2.image.enabled = true;
        Nfloresta.enabled = true;
        Nfloresta.image.enabled = true;

        BackFlorestaNorte.enabled = false;
        flor3.enabled = false;
        flor3.image.enabled = false;
        flor4.enabled = false;
        flor4.image.enabled = false;
        flor5.enabled = false;
        flor5.image.enabled = false;
        VFNorte.enabled = false;
        VFNorte.image.enabled = false;
    }
    //pedras voltar
    public void BPedraVoltar()
    {
        backPedras.enabled = false;
        BPedraV.enabled = false;
        BPedraV.image.enabled = false;

        backMap.enabled = true;
        mapV.enabled = true;
        mapV.image.enabled = true;
        mapC.enabled = true;
        mapC.image.enabled = true;
        mapF.enabled = true;
        mapF.image.enabled = true;
        BPedras.enabled = true;
        BPedras.image.enabled = true;
    }
	//floresta sul entrar
    public void BmapF()
    {

        BackFloresta.enabled = true;
        Vfloresta.enabled = true;
        Vfloresta.image.enabled = true;
        flor0.enabled = true;
        flor0.image.enabled = true;
        flor1.enabled = true;
        flor1.image.enabled = true;
        flor2.enabled = true;
        flor2.image.enabled = true;
        Nfloresta.enabled = true;
        Nfloresta.image.enabled = true;

        backMap.enabled = false;
        mapV.enabled = false;
        mapV.image.enabled = false;
        mapC.enabled = false;
        mapC.image.enabled = false;
        mapF.enabled = false;
        mapF.image.enabled = false;
		BPedras.enabled = false;
		BPedras.image.enabled = false;
    }
	//botao map voltar para menu inicial
    public void BmapV()
    {
        backMenu.enabled = true;
        backMap.enabled = false;
        Play.enabled = true;
        Play.image.enabled = true;
        Quit.enabled = true;
        Quit.image.enabled = true;
        mapV.enabled = false;
        mapV.image.enabled = false;
        mapC.enabled = false;
        mapC.image.enabled = false;
		BPedras.enabled = false;
		BPedras.image.enabled = false;
		mapF.enabled = false;
		mapF.image.enabled = false;

    }
	//botao map casa
    public void BmapC()
    {

        backCasa.enabled = true;
        casaMesa.enabled = true;
        casaP.enabled = true;
        casaP.image.enabled = true;
        casaQ.enabled = true;
        casaQ.image.enabled = true;
        backMap.enabled = false;
        mapC.enabled = false;
        mapC.image.enabled = false;
        mapV.enabled = false;
        mapV.image.enabled = false;
        mapF.enabled = false;
        mapF.image.enabled = false;
        BPedras.enabled = false;
        BPedras.image.enabled = false;

    }
	//botao mapa para pedras
    public void BmapP()
    {
        backPedras.enabled = true;
        BPedraV.enabled = true;
        BPedraV.image.enabled = true;
		BPedras.enabled = true;
		BPedras.image.enabled = true;
		firsten.enabled = true;
		firsten.image.enabled = true;


        backMap.enabled = false;
        mapV.enabled = false;
        mapV.image.enabled = false;
        mapC.enabled = false;
        mapC.image.enabled = false;
        mapF.enabled = false;
        mapF.image.enabled = false;
        BPedras.enabled = false;
        BPedras.image.enabled = false;
    }

	public void Bfristten()
	{
		if (Baga [5] >= 1) 
		{
			Baga[5] -= 1;
			countMF -= 1;
		}
		if (countMF <= 0) 
		{
			backPedras.enabled = false;
			firsten.enabled = false;
			firsten.image.enabled = false;
			BPedraV.enabled = false;
			BPedraV.image.enabled = false;

			backexplosion.enabled = true;
			BVoltarEXPLOSION.enabled = true;
			BVoltarEXPLOSION.image.enabled = true;

		}
	}

	public void BvoltarDAexplosion()
	{
		backPedras.enabled = true;
		firsten.enabled = true;
		firsten.image.enabled = true;
		BPedraV.enabled = true;
		BPedraV.image.enabled = true;

		backexplosion.enabled = false;
		BVoltarEXPLOSION.enabled = false;
		BVoltarEXPLOSION.image.enabled = false;
	}

	//menu botao play
    public void BPlay()
    {
        backMenu.enabled = false;
        backMap.enabled = true;
        Play.enabled = false;
        Play.image.enabled = false;
        Quit.enabled = false;
        Quit.image.enabled = false;
        mapV.enabled = true;
        mapV.image.enabled = true;
        mapC.enabled = true;
        mapC.image.enabled = true;
        mapF.enabled = true;
        mapF.image.enabled = true;
        BPedras.enabled = true;
        BPedras.image.enabled = true;

    }
	//menu botao quit
    public void BQuit()
    {
        quitmenu.enabled = true;
    }

    public void BQuitNao()
    {
        quitmenu.enabled = false;
    }
    public void BQuitSim()
    {
        Application.Quit();
    }


    // Crafts pó

    public void BV()
    {
        usar.enabled = false;
        usar.image.enabled = false;
        voltarQ.enabled = false;
        voltarQ.image.enabled = false;
        BackMortal.enabled = false;
        backQuartinho.enabled = true;
        quartinM.enabled = true;
        quartinM.image.enabled = true;
        quartinV.enabled = true;
        quartinV.image.enabled = true;
		quartinD.enabled = true;
		quartinD.image.enabled = true;


    }
    public void BUS()
    {
        if (b0n == 0)
        {
            b0.enabled = false;
            b0.image.enabled = false;
        }
        if (b0n == 1)
        {
            b0.enabled = true;
            b0.image.enabled = true;
        }
        usar.enabled = false;
        usar.image.enabled = false;
        voltaru.enabled = true;
        voltaru.image.enabled = true;
        voltarQ.enabled = false;
        voltarQ.image.enabled = false;
        less1.enabled = true;
        less1.image.enabled = true;
        plus1.enabled = true;
        plus1.image.enabled = true;
        b0.enabled = false;
        b0.image.enabled = false;



    }
    public void BVU()
    {
        usar.enabled = true;
        usar.image.enabled = true;
        voltaru.enabled = false;
        voltaru.image.enabled = false;
        voltarQ.enabled = true;
        voltarQ.image.enabled = true;
        usar.enabled = true;
        usar.image.enabled = true;
        b0.enabled = false;
        b0.image.enabled = false;
        b01.enabled = false;
        b01.image.enabled = false;
        b02.enabled = false;
        b02.image.enabled = false;
        i0.enabled = false;
        i0.image.enabled = false;
        i01.enabled = false;
        i01.image.enabled = false;
        i02.enabled = false;
        i02.image.enabled = false;
        i03.enabled = false;
        i03.image.enabled = false;
        i04.enabled = false;
        i04.image.enabled = false;
        i05.enabled = false;
        i05.image.enabled = false;
        less1.enabled = false;
        less1.image.enabled = false;
        plus1.enabled = false;
        plus1.image.enabled = false;
        

        b0n = 0;
        b0nb = 0;
        b01n = 0;
        b01nb = 0;
        b02n = 0;
        b02nb = 0;

    }

    //teste igredientes//
    public void BUI()
    {
        if (b0n == 0)
        {
            i0.enabled = false;
            i0.image.enabled = false;
            i01.enabled = false;
            i01.image.enabled = false;
            i02.enabled = false;
            i02.image.enabled = false;
            i03.enabled = false;
            i03.image.enabled = false;
            i04.enabled = false;
            i04.image.enabled = false;
            i05.enabled = false;
            i05.image.enabled = false;
            b0nc = 0;

        }
		if (b0n == 1 && igredientes[0] >= 1)
        {
			
            i0.enabled = true;
            i0.image.enabled = true;

            i01.enabled = false;
            i01.image.enabled = false;
            i02.enabled = false;
            i02.image.enabled = false;
            i03.enabled = false;
            i03.image.enabled = false;
            i04.enabled = false;
            i04.image.enabled = false;
            i05.enabled = false;
            i05.image.enabled = false;
            b0nc = 1;


        }
		if (b0n == 2 && igredientes[1] >= 1)
        {
            b0nc = 2;
            i01.enabled = true;
            i01.image.enabled = true;

            i02.enabled = false;
            i02.image.enabled = false;
            i0.enabled = false;
            i0.image.enabled = false;
            i03.enabled = false;
            i03.image.enabled = false;
            i04.enabled = false;
            i04.image.enabled = false;
            i05.enabled = false;
            i05.image.enabled = false;
        }
		if (b0n == 3 && igredientes[2] >= 1)
        {
            b0nc = 3;
            i02.enabled = true;
            i02.image.enabled = true;

            i01.enabled = false;
            i01.image.enabled = false;
            i0.enabled = false;
            i0.image.enabled = false;
            i03.enabled = false;
            i03.image.enabled = false;
            i04.enabled = false;
            i04.image.enabled = false;
            i05.enabled = false;
            i05.image.enabled = false;
        }
		if (b0n == 4 && igredientes[3] >= 1)
        {
            i0.enabled = false;
            i0.image.enabled = false;
            i01.enabled = false;
            i01.image.enabled = false;
            i02.enabled = false;
            i02.image.enabled = false;
            i03.enabled = true;
            i03.image.enabled = true;
            i04.enabled = false;
            i04.image.enabled = false;
            i05.enabled = false;
            i05.image.enabled = false;
            b0nc = 4;
        }
		if (b0n == 5 && igredientes[4] >= 1)
        {
            i0.enabled = false;
            i0.image.enabled = false;
            i01.enabled = false;
            i01.image.enabled = false;
            i02.enabled = false;
            i02.image.enabled = false;
            i03.enabled = false;
            i03.image.enabled = false;
            i04.enabled = true;
            i04.image.enabled = true;
            i05.enabled = false;
            i05.image.enabled = false;
            b0nc = 5;
        }
		if (b0n == 6 && igredientes[5] >= 1)
        {
            i0.enabled = false;
            i0.image.enabled = false;
            i01.enabled = false;
            i01.image.enabled = false;
            i02.enabled = false;
            i02.image.enabled = false;
            i03.enabled = false;
            i03.image.enabled = false;
            i04.enabled = false;
            i04.image.enabled = false;
            i05.enabled = true;
            i05.image.enabled = true;
            b0nc = 6;
        }
    }

    //controladores
    public void BUplus()
    {

        if (b0nb == 6)
        {
            b0n = 6;
            b0nb = 6;

        }
        else
        {
            b0n += 1;
            b0nb += 1;
        }
    }
    public void BUless()
    {
        if (b0nb == 0)
        {
            b0n = 0;
            b0nb = 0;
        }
        else
        {
            b0n -= 1;
            b0nb -= 1;
        }
    }

    //craft igredientes//
    public void Bi0 ()
    {
        somaR = true;
    }
    public void Bi01()
    {
        somaR = true;
    }
    public void Bi02()
    {
        somaR = true;
    }
    public void Bi03()
    {
        somaR = true;
    }
    public void Bi04()
    {
        somaR = true;
    }
    public void Bi05()
    {
        somaR = true;
    }

    public void Mix0()
    {
        Bag[0] += 1;
        igredientes[0] -= 1;
        somaR = false;
		i0.enabled = false;
		i0.image.enabled = false;

    }
    public void Mix01()
    {
        Bag[1] += 1;
        igredientes[1] -= 1;
        somaR = false;
		i01.enabled = false;
		i01.image.enabled = false;
    }
    public void Mix02()
    {
        Bag[2] += 1;
        igredientes[2] -= 1;
        somaR = false;
		i02.enabled = false;
		i02.image.enabled = false;
    }
    public void Mix03()
    {
        Bag[3] += 1;
        igredientes[3] -= 1;
        somaR = false;
		i03.enabled = false;
		i03.image.enabled = false;
    }
    public void Mix04()
    {
        Bag[4] += 1;
        igredientes[4] -= 1;
        somaR = false;
		i04.enabled = false;
		i04.image.enabled = false;
    }
    public void Mix05()
    {Bag[5] += 1;
     igredientes[5] -= 1;
     somaR = false;
		i05.enabled = false;
		i05.image.enabled = false;
    }
    void Update () {
		

		//Teste texto mostrando variavel


		if (contandotempo >= 1) 
		{
			contandotempo += 1*Time.deltaTime;

			if (contandotempo >= 5) 
			{
				contandotempo = 0;
				texto.enabled = false;
			}
		}
		
        //somaR//mix
        if(somaR == true)
        {
            if (i0.image.enabled == true)
            {    
                if(igredientes[0] > 0)
                {
                    Mix0();
                }                              
            }
            else
            {
                somaR = false;
            }
            if (i01.image.enabled == true)
            {
                if (igredientes[1] > 0)
                {
                    Mix01();
                }
            }
            else
            {
                somaR = false;
            }
            if (i02.image.enabled == true)
            {
                if (igredientes[2] > 0)
                {
                    Mix02();
                }
            }
            else
            {
                somaR = false;
            }
            if (i03.image.enabled == true)
            {
                if (igredientes[3] > 0)
                {
                    Mix03();
                }
            }
            else
            {
                somaR = false;
            }
            if (i04.image.enabled == true)
            {
                if (igredientes[4] > 0)
                {
                    Mix04();
                }
            }
            else
            {
                somaR = false;
            }
            if (i05.image.enabled == true)
            {
                if (igredientes[5] > 0)
                {
                    Mix05();
                }
            }
            else
            {
                somaR = false;
            }
        }        
        if (b0nb == 0)
        {
            b0.enabled = false;
            b0.image.enabled = false;
            b01.enabled = false;
            b01.image.enabled = false;
            b02.enabled = false;
            b02.image.enabled = false;
            b03.enabled = false;
            b03.image.enabled = false;
            b04.enabled = false;
            b04.image.enabled = false;
            b05.enabled = false;
            b05.image.enabled = false;
        }
        if (b0nb == 1)
        {
            b0.enabled = true;
            b0.image.enabled = true;
            b01.enabled = false;
            b01.image.enabled = false;
            b02.enabled = false;
            b02.image.enabled = false;
            b03.enabled = false;
            b03.image.enabled = false;
            b04.enabled = false;
            b04.image.enabled = false;
            b05.enabled = false;
            b05.image.enabled = false;
        }
        if (b0nb == 2)
        {
            b0.enabled = false;
            b0.image.enabled = false;
            b01.enabled = true;
            b01.image.enabled = true;
            b02.enabled = false;
            b02.image.enabled = false;
            b03.enabled = false;
            b03.image.enabled = false;
            b04.enabled = false;
            b04.image.enabled = false;
            b05.enabled = false;
            b05.image.enabled = false;
        }
        if (b0nb == 3)
        {
            b0.enabled = false;
            b0.image.enabled = false;
            b01.enabled = false;
            b01.image.enabled = false;
            b02.enabled = true;
            b02.image.enabled = true;
            b03.enabled = false;
            b03.image.enabled = false;
            b04.enabled = false;
            b04.image.enabled = false;
            b05.enabled = false;
            b05.image.enabled = false;
        }
        if (b0nb == 4)
        {
            b0.enabled = false;
            b0.image.enabled = false;
            b01.enabled = false;
            b01.image.enabled = false;
            b02.enabled = false;
            b02.image.enabled = false;
            b03.enabled = true;
            b03.image.enabled = true;
            b04.enabled = false;
            b04.image.enabled = false;
            b05.enabled = false;
            b05.image.enabled = false;

        }
        if (b0nb == 5)
        {
            b0.enabled = false;
            b0.image.enabled = false;
            b01.enabled = false;
            b01.image.enabled = false;
            b02.enabled = false;
            b02.image.enabled = false;
            b03.enabled = false;
            b03.image.enabled = false;
            b04.enabled = true;
            b04.image.enabled = true;
            b05.enabled = false;
            b05.image.enabled = false;

        }
        if (b0nb == 6)
        {
            b0.enabled = false;
            b0.image.enabled = false;
            b01.enabled = false;
            b01.image.enabled = false;
            b02.enabled = false;
            b02.image.enabled = false;
            b03.enabled = false;
            b03.image.enabled = false;
            b04.enabled = false;
            b04.image.enabled = false;
            b05.enabled = true;
            b05.image.enabled = true;
        }

    }

}

