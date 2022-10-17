using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    private int questionNumber;
    private string subject;
    [SerializeField] private GameObject visual001;
    
    void Start()
    {
        subject = SceneManager.GetActiveScene().name;
        Debug.Log("Active scene : " + subject);
    }

    void Update()
    {
        //8. Sinif matematik
        if(displayingQuestion == false && subject == "UsluSayilar")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 7);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "How much wood could a wood chuck chuck if a wood chuck could chuck wood?";
                QuestionDisplay.newA = "A. Lots and lots";
                QuestionDisplay.newB = "B. None";
                QuestionDisplay.newC = "C. Hardly any";
                QuestionDisplay.newD = "D. Six";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Who is the brother of Luigi?";
                QuestionDisplay.newA = "A. D.K";
                QuestionDisplay.newB = "B. Toad";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                actualAnswer = "C";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Where is Japan?";
                QuestionDisplay.newA = "A. Africa";
                QuestionDisplay.newB = "B. Asia";
                QuestionDisplay.newC = "C. Europe";
                QuestionDisplay.newD = "D. Antartica";
                actualAnswer = "B";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            if(questionNumber == 5)
            { 
                QuestionDisplay.newQuestion = "How old the is world?";
                QuestionDisplay.newA = "A. 1400 years";
                QuestionDisplay.newB = "B. 6 months";
                QuestionDisplay.newC = "C. 10 years";
                QuestionDisplay.newD = "D. Billons of years";
                actualAnswer = "D";
            }

            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Which video game series would you see this?";
                QuestionDisplay.newA = "A. Zelda";
                QuestionDisplay.newB = "B. Halo";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                visual001.SetActive(true);
                actualAnswer = "C";
            }

            QuestionDisplay.pleaseUpdate = false;

        }

        if(displayingQuestion == false && subject == "KokluSayilar")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "27 kok 3, kac'a esittir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 6";
                QuestionDisplay.newC = "C. 3";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "C";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "81'in karekoku kactir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 12";
                QuestionDisplay.newC = "C. 6";
                QuestionDisplay.newD = "D. 21";
                actualAnswer = "A";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }

        //8.Sinif turkce
        if(displayingQuestion == false && subject == "SozcukteAnlam")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Ara sira ahiretten haber gelseydi, ölüm bu kadar müthiş olmayacakti. Giden gidiyor, hiç dönmüyor ve gittiği yerden hiç ses çikmiyor. Dönmesin kalsin. Fakat bu ağir, bu yoğun, bu korkunç sessizlik neden?\n\nAşağidakilerden hangisi, bu parçada geçen “ağir” sözcüğünün anlamca yerini tutamaz?";
                QuestionDisplay.newA = "A. Bunaltici";
                QuestionDisplay.newB = "B. Sikinti verici";
                QuestionDisplay.newC = "C. Dehşetli";
                QuestionDisplay.newD = "D. Duygusuz";
                actualAnswer = "D";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = " Bizi düşündüren, her zaman iki seçenekten birini tercih etmek oluyor. Peki, ortada iki seçenek olduğundan neden bu kadar eminiz? —- mecburi istikamet farkli kiliklara büründürülüyor ve iki ayri seçenek olarak önümüze sürülüyordur.\n\nYukaridaki parçada boş birakilan yere aşağidakilerden hangisi getirilmelidir?";
                QuestionDisplay.newA = "A. Çünkü";
                QuestionDisplay.newB = "B. Belki de";
                QuestionDisplay.newC = "C. Buna rağmen";
                QuestionDisplay.newD = "D. Ama";
                actualAnswer = "B";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }

        if(displayingQuestion == false && subject == "CumledeAnlam")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "27 kok 3, kac'a esittir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 6";
                QuestionDisplay.newC = "C. 3";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "C";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "81'in karekoku kactir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 12";
                QuestionDisplay.newC = "C. 6";
                QuestionDisplay.newD = "D. 21";
                actualAnswer = "A";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }

        //12.Sinif Mat
        if(displayingQuestion == false && subject == "Diziler")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "27 kok 3, kac'a esittir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 6";
                QuestionDisplay.newC = "C. 3";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "C";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "81'in karekoku kactir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 12";
                QuestionDisplay.newC = "C. 6";
                QuestionDisplay.newD = "D. 21";
                actualAnswer = "A";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }

        if(displayingQuestion == false && subject == "Logaritma")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "27 kok 3, kac'a esittir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 6";
                QuestionDisplay.newC = "C. 3";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "C";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "81'in karekoku kactir?";
                QuestionDisplay.newA = "A. 9";
                QuestionDisplay.newB = "B. 12";
                QuestionDisplay.newC = "C. 6";
                QuestionDisplay.newD = "D. 21";
                actualAnswer = "A";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }

        //12.Sinif Edebiyat
        if(displayingQuestion == false && subject == "IletisimDil")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Ara sira ahiretten haber gelseydi, ölüm bu kadar müthiş olmayacakti. Giden gidiyor, hiç dönmüyor ve gittiği yerden hiç ses çikmiyor. Dönmesin kalsin. Fakat bu ağir, bu yoğun, bu korkunç sessizlik neden?\n\nAşağidakilerden hangisi, bu parçada geçen “ağir” sözcüğünün anlamca yerini tutamaz?";
                QuestionDisplay.newA = "A. Bunaltici";
                QuestionDisplay.newB = "B. Sikinti verici";
                QuestionDisplay.newC = "C. Dehşetli";
                QuestionDisplay.newD = "D. Duygusuz";
                actualAnswer = "D";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = " Bizi düşündüren, her zaman iki seçenekten birini tercih etmek oluyor. Peki, ortada iki seçenek olduğundan neden bu kadar eminiz? —- mecburi istikamet farkli kiliklara büründürülüyor ve iki ayri seçenek olarak önümüze sürülüyordur.\n\nYukaridaki parçada boş birakilan yere aşağidakilerden hangisi getirilmelidir?";
                QuestionDisplay.newA = "A. Çünkü";
                QuestionDisplay.newB = "B. Belki de";
                QuestionDisplay.newC = "C. Buna rağmen";
                QuestionDisplay.newD = "D. Ama";
                actualAnswer = "B";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }

        if(displayingQuestion == false && subject == "SozcukteVeSozObeklerindeAnlam")
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Ara sira ahiretten haber gelseydi, ölüm bu kadar müthiş olmayacakti. Giden gidiyor, hiç dönmüyor ve gittiği yerden hiç ses çikmiyor. Dönmesin kalsin. Fakat bu ağir, bu yoğun, bu korkunç sessizlik neden?\n\nAşağidakilerden hangisi, bu parçada geçen “ağir” sözcüğünün anlamca yerini tutamaz?";
                QuestionDisplay.newA = "A. Bunaltici";
                QuestionDisplay.newB = "B. Sikinti verici";
                QuestionDisplay.newC = "C. Dehşetli";
                QuestionDisplay.newD = "D. Duygusuz";
                actualAnswer = "D";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = " Bizi düşündüren, her zaman iki seçenekten birini tercih etmek oluyor. Peki, ortada iki seçenek olduğundan neden bu kadar eminiz? —- mecburi istikamet farkli kiliklara büründürülüyor ve iki ayri seçenek olarak önümüze sürülüyordur.\n\nYukaridaki parçada boş birakilan yere aşağidakilerden hangisi getirilmelidir?";
                QuestionDisplay.newA = "A. Çünkü";
                QuestionDisplay.newB = "B. Belki de";
                QuestionDisplay.newC = "C. Buna rağmen";
                QuestionDisplay.newD = "D. Ama";
                actualAnswer = "B";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "144'un karekoku kactir?";
                QuestionDisplay.newA = "A. 13";
                QuestionDisplay.newB = "B. 11";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 12";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
            
        }
    }
}
