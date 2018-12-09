using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL

            //bool charToBoolImplicit = sex;                            //IMPLICIT: NOT COMPILING
            //bool charToBoolExplicit = (bool)sex;                      //EXPLICIT: NOT COMPILING
            //bool charToBoolUsingConverter = Convert.ToBoolean(sex);   //CONVERT: NOT COMPILING
            //bool charToBoolUsingConverter2 = Convert.ToBoolean(hasFingerPrints);   //CONVERT: NOT COMPILING

            //1.3 CHAR to DECIMAL

            decimal charToDecimalImplicit = sex;                           //IMPLICIT: 1052 (best option)
            decimal charToDecimalExplicit = (decimal)sex;                  //EXPLICIT: 1052 ((decimal) unnecessary cast)
            //decimal charToDecimalConverter = Convert.ToDecimal(sex);     //CONVERT: NOT COMPILING
            //decimal charToDecimalConverter = Convert.ToDecimal(place);   //CONVERT: NOT COMPILING

            //1.4 CHAR to INT

            int charToIntImplicit = sex;                                   //IMPLICIT: 1052 (best option)
            int charToIntExplicit = (int)sex;                              //EXPLICIT: 1052 ((int) unnecessary cast)
            int charToIntConverter = Convert.ToInt32(sex);                 //CONVERT: 1052

            //2. STRING CONVERSION
            //2.1 STRING to CHAR

            //char stringToCharImplicit = name;                            //IMPLICIT: NOT COMPILING
            //char stringToCharExplicit = (char)name;                      //EXPLICIT: NOT COMPILING
            //char stringToCharConverter = Convert.ToChar(name);           //CONVERT:  NOT COMPILING, т.к.длина строки д.б. не более 1-го знака

            //2.2 STRING to BOOL

            //bool stringToBoolImplicit = hasPhoto;                              //IMPLICIT: NOT COMPILING
            //bool stringToBoolExplicit = (bool)hasPhoto;                        //EXPLICIT: NOT COMPILING
            bool stringToBoolConverter = Convert.ToBoolean(hasPhoto);           //CONVERT:  True

            //2.3 STRING to DECIMAL

            //decimal stringToDecimalImplicit = flatNumber;                    //IMPLICIT: NOT COMPILING
            //decimal stringToDecimalExplicit = (decimal)flatNumber;           //EXPLICIT: NOT COMPILING
            decimal stringToDecimalConverter = Convert.ToDecimal(flatNumber);  //CONVERT:  34

            //2.4 STRING to INT

            //int stringToIntImplicit = flatNumber;                           //IMPLICIT: NOT COMPILING
            //int stringToIntExplicit = (int)flatNumber;                      //EXPLICIT: NOT COMPILING
            int stringToIntConverter = Convert.ToInt32(flatNumber);           //CONVERT: 34

            //3. BOOL CONVERSION
            //3.1 BOOL to CHAR

            //char boolToCharImplicit = hasFree2Pages;                            //IMPLICIT: NOT COMPILING
            //char boolToCharExplicit = (char)hasFree2Pages;                      //EXPLICIT: NOT COMPILING
            //char boolToCharConverter = Convert.ToChar(hasFree2Pages);           //CONVERT:  NOT COMPILING

            //3.2 BOOL to STRING

            //string boolToStringImplicit = hasFree2Pages;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            string boolToStringUsingConverter = Convert.ToString(hasFree2Pages);  //CONVERT: "False"

            //3.3 BOOL to DECIMAL

            //decimal boolToDecimalImplicit = hasFree2Pages;                          //IMPLICIT: NOT COMPILING
            //decimal boolToDecimalExplicit = (decimal)hasFree2Pages;                 //EXPLICIT: NOT COMPILING
            decimal boolToDecimalConverter = Convert.ToDecimal(hasFree2Pages);        //CONVERT: 0

            //3.4 BOOL to INT

            //int boolToIntImplicit = hasFree2Pages;                     //IMPLICIT: NOT COMPILING
            //int boolToIntExplicit = (int)hasFree2Pages;                //EXPLICIT: NOT COMPILING
            int boolToIntConverter = Convert.ToInt32(hasFree2Pages);     //CONVERT:0

            //4. DOUBLE CONVERSION
            //4.1 DOUBLE to CHAR

            //char doubleToCharImplicit = visaPrice;                      //IMPLICIT: NOT COMPILING
            char doubleToCharExplicit = (char)visaPrice;                  //EXPLICIT: '<'
            char doubleToCharExplicit2 = (char)photoPrice;                //EXPLICIT: скомпилируется, на консоль, ничего не выведет, но будет звуковой
                                                                          //сигнал, "5" отпадает, а числу "7" по табл. Unicode соотв. звук. сигнал
                                                                          //char doubleToCharConverter = Convert.ToChar(visaPrice);     //CONVERT:NOT COMPILING

            //4.2 DOUBLE to BOOL

            //bool doubleToBoolImplicit = photoPrice;                            //IMPLICIT: NOT COMPILING
            //bool doubleToBoolExplicit = (bool)photoPrice;                      //EXPLICIT: NOT COMPILING
            bool doublecharToBoolUsingConverter = Convert.ToBoolean(photoPrice); //CONVERT: True                                   

            //4.3 DOUBLE to STRING

            //string doubleToStringImplicit = photoPrice;                            //IMPLICIT: NOT COMPILING
            //string doubleToStringExplicit = (string)photoPrice;                    //EXPLICIT: NOT COMPILING
            string doublecharToStringUsingConverter = Convert.ToString(photoPrice);  //CONVERT: "7,5" 

            //4.4 DOUBLE to INT

            //int doubleToIntImplicit = photoPrice;                        //IMPLICIT: NOT COMPILING
            int doubleToIntExplicit = (int)photoPrice;                     //EXPLICIT: 7
            int doubleToIntUsingConverter = Convert.ToInt32(photoPrice);   //CONVERT: 8 

            //5. INT CONVERSION         
            //5.1 INT to CHAR

            //char intToCharImplicit = birthYear;                  //IMPLICIT: NOT COMPILING
            char intToCharExplicit = (char)birthYear;              //EXPLICIT: 'ߐ' (но на консоли воводит ?)
            char intToCharConverter = Convert.ToChar(birthYear);   //CONVERT:'ߐ' (но на консоли воводит ?)

            //5.2 INT to BOOL

            //bool intToBoolImplicit = birthYear;                    //IMPLICIT: NOT COMPILING
            //bool intToBoolExplicit = (bool)birthYear;              //EXPLICIT: NOT COMPILING
            bool intToBoolConverter = Convert.ToBoolean(birthYear);  //CONVERT:True

            //5.3 INT to DECIMAL

            decimal intToDEcimalImplicit = birthYear;                    //IMPLICIT:2000 (best option)
            decimal intToDecimalExplicit = (decimal)birthYear;           //EXPLICIT:2000 ((int) unnecessary cast)
            decimal intToDecimalConverter = Convert.ToDecimal(birthYear);//CONVERT:2000


            //5.4 INT to STRING

            //string intToStringImplicit = birthYear;                    //IMPLICIT: NOT COMPILING
            //string intToStringExplicit = (string)birthYear;            //EXPLICIT: NOT COMPILING
            string intToStringConverter = Convert.ToString(birthYear);   //CONVERT:"2000"

        }
    }
}
