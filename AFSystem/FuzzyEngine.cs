using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSystem
{
    public class FuzzyEngine
    {
       
        //Varibel Input
        //Speed
        public float mfSpeedSlow { get; set; } = 0;
        public float mfSpeedMedium { get; set; } = 0;
        public float mfSpeedFast { get; set; } = 0;
        //Distance
        public float mfDistanceNear { get; set; } = 0;
        public float mfDistanceFar { get; set; } = 0;
        public float mfDistanceTooFar { get; set; } = 0;
        //Angle
        public float mfAngleDown { get; set; } = 0;
        public float mfAngleFlat { get; set; } = 0;
        public float mfAngleUp { get; set; } = 0;

        //Varibel Output
        //Brake Level
        float[] mfBrakeWeak = new float[27];
        float[] mfBrakeMedium = new float[27];
        float[] mfBrakeStrong = new float[27];
        public float BrakeWeak { get; set; }
        public float BrakeMedium { get; set; }
        public float BrakeStrong { get; set; }
        public float minBrakeLevel { get; set; } = 0;
        public float maxBrakeLevel { get; set; } = 10;

        //Varibel FuzzyEngine
        public float Crisp { get; set; }

        //Fuzifikasi
        //Member Functuion Declaraition Area
        //Speed AREA
        public void Speed(float iSpeed)
        {
            //Linguistik Slow
            if (iSpeed <= 30)
            {
                mfSpeedSlow = 1;
            }
            else
            {
                if (iSpeed < 50)
                {
                    mfSpeedSlow = (float)((50 - iSpeed) / 20);
                }
                else mfSpeedSlow = 0;
            }
            //Linguistik Medium
            if ((iSpeed <= 40) || (iSpeed >= 80))
            {
                mfSpeedMedium = 0;
            }
            else
            {
                if (iSpeed <= 60)
                {
                    mfSpeedMedium = (float)((iSpeed - 40) / 20);
                }
                else
                {
                    if (iSpeed > 60 && iSpeed < 80)
                    {
                        mfSpeedMedium = (float)((-iSpeed + 80) / 20);
                    }
                    else mfSpeedMedium = 1;
                }
            }
            //Linguistik Fast
            if (iSpeed <= 70)
            {
                mfSpeedFast = 0;
            }
            else
            {
                if (iSpeed < 90)
                {
                    mfSpeedFast = (float)((iSpeed - 70) / 20);
                }
                else mfSpeedFast = 1;
            }
        }
        //Distance AREA

        public void Distance(float iDistance)
        {
            //Linguistik Near

            if (iDistance <= 1)
            {
                mfDistanceNear = 1;
            }
            else
            {
                if (iDistance < 2)
                {
                    mfDistanceNear = (float)((2 - iDistance) / 1);
                }
                else mfDistanceNear = 0;
            }
            //Linguistik Far
            if ((iDistance <= 1) || (iDistance >= 5))
            {
                mfDistanceFar = 0;
            }
            else
            {
                if (iDistance < 4)
                {
                    mfDistanceFar = (float)((iDistance - 1) / 3);
                }
                else
                {
                    if (iDistance > 4 && iDistance < 5)
                    {
                        mfDistanceFar = (float)((-iDistance + 5) / 1);
                    }
                    else mfDistanceFar = 1;
                }
            }
            //Linguistik TooFar
            if (iDistance <= 4)
            {
                mfDistanceTooFar = 0;
            }
            else
            {
                if (iDistance < 7)
                {
                    mfDistanceTooFar = (float)((iDistance - 4) / 3);
                }
                else mfDistanceTooFar = 1;
            }
        }

        //Angle AREA
        public void Angle(float iAngle)
        {
            //Linguistik Down

            if (iAngle <= (-40))
            {
                mfAngleDown = 1;
            }
            else
            {
                if (iAngle < (-20))
                {
                    mfAngleDown = (float)(((-20) - iAngle) / 20);
                }
                else mfAngleDown = 0;
            }

            //Linguistik Flat
            if ((iAngle <= (-30)) || (iAngle >= 30))
            {
                mfAngleFlat = 0;
            }
            else
            {
                if (iAngle < 0)
                {
                    mfAngleFlat = (float)((iAngle - (-30)) / 30);
                }
                else
                {
                    if (iAngle > 0 && iAngle < 30)
                    {
                        mfAngleFlat = (float)((-iAngle + 30) / 30);
                    }
                    else mfAngleFlat = 1;
                }
            }

            //Linguistik Up
            if (iAngle <= 20)
            {
                mfAngleUp = 0;
            }
            else
            {
                if (iAngle < 40)
                {
                    mfAngleUp = (float)((iAngle - 20) / 20);
                }
                else mfAngleUp = 1;
            }
        }

        //Call Area Member Functuion
        public void MemberFunction()
        {
            Console.WriteLine("Fuzzy Speed : Slow " + mfSpeedSlow + " | Medium " + mfSpeedMedium + " | Fast " + mfSpeedFast);
            Console.WriteLine("Fuzzy Distance : Near " + mfDistanceNear + " | Far " + mfDistanceFar + " | TooFar " + mfDistanceTooFar);
            Console.WriteLine("Fuzzy Angle : Down " + mfAngleDown + " | Flat " + mfAngleFlat + " | Up " + mfAngleUp);
        }

        //Implication
        public float min(float iSpeed, float iDistance, float iAngle)
        {
            if (iSpeed < iDistance && iSpeed < iAngle)
            {
                return iSpeed;
            }
            else
            {
                if (iDistance < iSpeed && iDistance < iAngle)
                {
                    return iDistance;
                }
                else return iAngle;
            }
        }

        //Aggregation
        public float max_brakelevel(float[] data, int N)
        {
            float max = (float)0.0;
            for (int i = 0; i < N; i++)
            {
                if (data[i] > max) max = data[i];
            }
            return max;
        }

        //RULES
        public void Rules()
        {
            int i = 0, j = 0, k = 0;
            if (mfSpeedSlow != 0 && mfDistanceNear != 0 && mfAngleDown != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedSlow, mfDistanceNear, mfAngleDown);
                Console.WriteLine("Rules 1 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedSlow != 0 && mfDistanceNear != 0 && mfAngleFlat != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedSlow, mfDistanceNear, mfAngleFlat);
                Console.WriteLine("Rules 2 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedSlow != 0 && mfDistanceNear != 0 && mfAngleUp != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedSlow, mfDistanceNear, mfAngleUp);
                Console.WriteLine("Rules 3 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedSlow != 0 && mfDistanceFar != 0 && mfAngleDown != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedSlow, mfDistanceFar, mfAngleDown);
                Console.WriteLine("Rules 4 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedSlow != 0 && mfDistanceFar != 0 && mfAngleFlat != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedSlow, mfDistanceFar, mfAngleFlat);
                Console.WriteLine("Rules 5 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedSlow != 0 && mfDistanceFar != 0 && mfAngleUp != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedSlow, mfDistanceFar, mfAngleUp);
                Console.WriteLine("Rules 6 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedSlow != 0 && mfDistanceTooFar != 0 && mfAngleDown != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedSlow, mfDistanceTooFar, mfAngleDown);
                Console.WriteLine("Rules 7 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedSlow != 0 && mfDistanceTooFar != 0 && mfAngleFlat != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedSlow, mfDistanceTooFar, mfAngleFlat);
                Console.WriteLine("Rules 8 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedSlow != 0 && mfDistanceTooFar != 0 && mfAngleUp != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedSlow, mfDistanceTooFar, mfAngleUp);
                Console.WriteLine("Rules 9 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedMedium != 0 && mfDistanceNear != 0 && mfAngleDown != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedMedium, mfDistanceNear, mfAngleDown);
                Console.WriteLine("Rules 10 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedMedium != 0 && mfDistanceNear != 0 && mfAngleFlat != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedMedium, mfDistanceNear, mfAngleFlat);
                Console.WriteLine("Rules 11 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedMedium != 0 && mfDistanceNear != 0 && mfAngleUp != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedMedium, mfDistanceNear, mfAngleUp);
                Console.WriteLine("Rules 12 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedMedium != 0 && mfDistanceFar != 0 && mfAngleDown != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedMedium, mfDistanceFar, mfAngleDown);
                Console.WriteLine("Rules 13 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedMedium != 0 && mfDistanceFar != 0 && mfAngleFlat != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedMedium, mfDistanceFar, mfAngleFlat);
                Console.WriteLine("Rules 14 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedMedium != 0 && mfDistanceFar != 0 && mfAngleUp != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedMedium, mfDistanceFar, mfAngleUp);
                Console.WriteLine("Rules 15 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedMedium != 0 && mfDistanceTooFar != 0 && mfAngleDown != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedMedium, mfDistanceTooFar, mfAngleDown);
                Console.WriteLine("Rules 16 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedMedium != 0 && mfDistanceTooFar != 0 && mfAngleFlat != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedMedium, mfDistanceTooFar, mfAngleFlat);
                Console.WriteLine("Rules 17 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedMedium != 0 && mfDistanceTooFar != 0 && mfAngleUp != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedMedium, mfDistanceTooFar, mfAngleUp);
                Console.WriteLine("Rules 18 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            if (mfSpeedFast != 0 && mfDistanceNear != 0 && mfAngleDown != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedFast, mfDistanceNear, mfAngleDown);
                Console.WriteLine("Rules 19 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedFast != 0 && mfDistanceNear != 0 && mfAngleFlat != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedFast, mfDistanceNear, mfAngleFlat);
                Console.WriteLine("Rules 20 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedFast != 0 && mfDistanceNear != 0 && mfAngleUp != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedFast, mfDistanceNear, mfAngleUp);
                Console.WriteLine("Rules 21 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedFast != 0 && mfDistanceFar != 0 && mfAngleDown != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedFast, mfDistanceFar, mfAngleDown);
                Console.WriteLine("Rules 22 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedFast != 0 && mfDistanceFar != 0 && mfAngleFlat != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedFast, mfDistanceFar, mfAngleFlat);
                Console.WriteLine("Rules 23 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedFast != 0 && mfDistanceFar != 0 && mfAngleUp != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedFast, mfDistanceFar, mfAngleUp);
                Console.WriteLine("Rules 24 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedFast != 0 && mfDistanceTooFar != 0 && mfAngleDown != 0)
            {
                mfBrakeStrong[k] = min(mfSpeedFast, mfDistanceTooFar, mfAngleDown);
                Console.WriteLine("Rules 25 -> Breke Level Strong : " + mfBrakeStrong[k]);
                k++;
            }
            if (mfSpeedFast != 0 && mfDistanceTooFar != 0 && mfAngleFlat != 0)
            {
                mfBrakeMedium[j] = min(mfSpeedFast, mfDistanceTooFar, mfAngleFlat);
                Console.WriteLine("Rules 26 -> Breke Level Medium : " + mfBrakeMedium[j]);
                j++;
            }
            if (mfSpeedFast != 0 && mfDistanceTooFar != 0 && mfAngleUp != 0)
            {
                mfBrakeWeak[i] = min(mfSpeedFast, mfDistanceTooFar, mfAngleUp);
                Console.WriteLine("Rules 27 -> Breke Level Weak : " + mfBrakeWeak[i]);
                i++;
            }
            //Breke Inference Area
            if (i == 0) BrakeWeak = (float)0.0;
            else BrakeWeak = max_brakelevel(mfBrakeWeak, i);
            if (j == 0) BrakeMedium = (float)0.0;
            else BrakeMedium = max_brakelevel(mfBrakeMedium, j);
            if (k == 0) BrakeStrong = (float)0.0;
            else BrakeStrong = max_brakelevel(mfBrakeStrong, k);

            Console.WriteLine("Break Level Area : ");
            Console.WriteLine();
            Console.WriteLine("Weak : " + BrakeWeak + " | Medium " + BrakeMedium + " | Strong " + BrakeStrong);
        }

        //Membership Function BreakLevel
        public float dBreakWeak(float x)
        {
            if (x <= 3) return 1;
            else
            {
                if (x < 4) return (float)((4 - x) / 1);
                else return 0;
            }
        }
        public float dBreakMedium(float x)
        {
            if (x >= 4 && x <= 6) return 1;
            else
            {
                if (x > 3 && x < 4) return (float)((x - 3) / 1);
                else
                {
                    if (x > 6 && x < 7) return 1;
                    else return 0;
                }
            }
        }
        public float dBreakStrong(float x)
        {
            if (x <= 6) return 0;
            else
            {
                if (x < 7) return (float)((x - 6) / 1);
                else return 1;
            }
        }

        public float max(float weak, float medium, float strong)
        {
            if (weak > medium && weak > strong)
            {
                return weak;
            }
            else
            {
                if (medium > weak && medium > strong)
                {
                    return medium;
                }
                else return strong;
            }
        }

        public void Centroid(float Sample)
        {
            float t = (maxBrakeLevel - minBrakeLevel) / Sample;
            float[] xBrakeLevelWeak = new float[50];
            float[] xBrakeLevelMedium = new float[50];
            float[] xBrakeLevelStrong = new float[50];
            float[] xOthers = new float[50];
            float[] others = new float[50];
            float[] mul = new float[100];
            float[] samples = new float[100];
            float dWeak, dMedium, dStrong;
            float valCrisp = 0;
            float Divider = 0;
            float x = minBrakeLevel;
            int i, iWeak = 0, iMedium = 0, iStrong = 0, iothers = 0;
            String result = "";

            for (i = 0; i < Sample; i++)
            {
                x = x + t;
                samples[i] = x;
                dWeak = dBreakWeak(x);
                dMedium = dBreakMedium(x);
                dStrong = dBreakStrong(x);
                if (dWeak > BrakeWeak) dWeak = BrakeWeak;
                if (dMedium > BrakeMedium) dMedium = BrakeMedium;
                if (dStrong > BrakeStrong) dStrong = BrakeStrong;
                mul[i] = max(dWeak, dMedium, dStrong);
                if (mul[i] == BrakeWeak)
                {
                    xBrakeLevelWeak[iWeak] = x;
                    iWeak++;
                }
                else
                {
                    if (mul[i] == iMedium)
                    {
                        xBrakeLevelMedium[iMedium] = x;
                        iMedium++;
                    }
                    else
                    {
                        if (mul[i] == iStrong)
                        {
                            xBrakeLevelStrong[iStrong] = x;
                        }
                        else
                        {
                            xOthers[iothers] = x;
                            others[iothers] = mul[i];
                            iothers++;
                        }
                    }
                }
                valCrisp = valCrisp + x * mul[i];
                Divider = Divider + mul[i];
            }
            Console.WriteLine("Crisp Value : " + valCrisp);
            Console.WriteLine("Divider " + Divider);
            Crisp = valCrisp / Divider;
            Console.WriteLine();
            //cetak perhitungan centroid method
            Console.WriteLine("Brake Level : " + Crisp);
        }
    }
}
