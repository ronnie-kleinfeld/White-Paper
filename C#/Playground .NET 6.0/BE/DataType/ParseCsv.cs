using System;
using System.Text;

namespace BE.DataType
{
    public class ParseCsv
    {
        // consts
        private const char CommaChar = ',';
        private const char QuoteChar = '\"';

        // members
        private Guid guid;
        private char comma;
        private char quote;
        private string slashGuid;
        private string commaGuid;
        private StringBuilder stringBuilder;

        // properties
        public char Comma
        {
            get
            {
                return comma;
            }
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new ArgumentException("Comma character is required.", value.ToString());
                } else if (value == ' ')
                {
                    throw new ArgumentException("Comma character can not be space.", value.ToString());
                } else
                {
                    comma = value;
                }
            }
        }
        public char Quote
        {
            get
            {
                return quote;
            }
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new ArgumentException("Quote character is required.", value.ToString());
                } else if (value == ' ')
                {
                    throw new ArgumentException("Quote character can not be space.", value.ToString());
                } else
                {
                    quote = value;
                }
            }
        }

        // class
        public ParseCsv()
        {
            guid = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd");
            stringBuilder = new StringBuilder(255);
            Quote = QuoteChar;
            Comma = CommaChar;
            commaGuid = Guid.NewGuid().ToString();
            slashGuid = Guid.NewGuid().ToString();
        }

        // methods
        public string[] Parse(string pStrString)
        {
            return null;
            //string strComma = m_cComma.ToString();
            //string strQuote = m_cQuote.ToString();
            //if (p_strString.Length > 0)
            //{
            //    m_sb.Remove(0, m_sb.Length);
            //    m_sb.Append(p_strString);
            //    string[] a_strWords;

            //    if (m_sb.ToString().IndexOf(m_cQuote) == 0)
            //    {
            //        return m_sb.ToString().Split(m_cComma);
            //    }
            //    else
            //    {
            //        // special case (\,\)
            //        m_sb.Replace(strQuote + strComma + strQuote, strQuote + m_strCommaGuid + strQuote);
            //        m_sb.Replace(strQuote + strQuote, m_strSlashGuid);

            //        string str = m_sb.ToString();
            //        int i1;
            //        int i2 = 1;
            //        i1 = InStr(i2, str, strQuote, CompareMethod.Binary);
            //        i2 = InStr(i1 + 1, str, strQuote, CompareMethod.Binary);

            //        if (i1 > 0 && i2 > 1)
            //        {
            //            StringBuilder sb2 = new StringBuilder();
            //            sb2 = m_sb.Replace(strComma, m_strCommaGuid, i1 + 1, i2 - i1 - 1);
            //            i2 = i2 + 36;

            //            while (m_sb == sb2)
            //            {
            //                str = m_sb.ToString();
            //                i1 = InStr(i2, str, strQuote, CompareMethod.Binary);
            //                if (i1 == 0)
            //                {
            //                    exit;
            //                }
            //                i2 = InStr(i1 + 1, str, strQuote, CompareMethod.Binary);

            //                sb2 = m_sb.Replace(strComma, m_strCommaGuid, i1 + 1, i2 - i1 - 1);
            //                i2 = i2 + 36;
            //            }

            //            sb2 = null;
            //        }

            //        // remove the slash on the left and right of a string
            //        m_sb.Replace(strQuote, "");
            //        // return the strings slash but now they are single and not doubled
            //        m_sb.Replace(m_strSlashGuid, strQuote);

            //        a_strWords = m_sb.ToString().Split(m_cComma);

            //        for (int i = 0; i < a_strWords.Length; i++)
            //        {
            //            a_strWords[i] = a_strWords[i].Replace(m_strCommaGuid, strComma);
            //        }
            //    }
            //    return a_strWords;
            //}
        }
    }
}
