/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.Collections.Generic;
using System.Text;

namespace IB.Tws.Client
{
    public static class Util
    {
        public static bool StringIsEmpty(string str)
        {
            return str == null || str.Length == 0;
        }


        public static string NormalizeString(string str)
        {
            return str != null ? str : "";
        }

        public static int StringCompare(string lhs, string rhs)
        {
            return NormalizeString(lhs).CompareTo(NormalizeString(rhs));
        }

        public static int StringCompareIgnCase(string lhs, string rhs)
        {
            string normalisedLhs = NormalizeString(lhs);
            string normalisedRhs = NormalizeString(rhs);
            return String.Compare(normalisedLhs, normalisedRhs, true);
        }

        public static bool VectorEqualsUnordered<T>(List<T> lhs, List<T> rhs)
        {

            if (lhs == rhs)
                return true;

            int lhsCount = lhs == null ? 0 : lhs.Count;
            int rhsCount = rhs == null ? 0 : rhs.Count;

            if (lhsCount != rhsCount)
                return false;

            if (lhsCount == 0)
                return true;

            bool[] matchedRhsElems = new bool[rhsCount];

            for (int lhsIdx = 0; lhsIdx < lhsCount; ++lhsIdx)
            {
                Object lhsElem = lhs[lhsIdx];
                int rhsIdx = 0;
                for (; rhsIdx < rhsCount; ++rhsIdx)
                {
                    if (matchedRhsElems[rhsIdx])
                    {
                        continue;
                    }
                    if (lhsElem.Equals(rhs[rhsIdx]))
                    {
                        matchedRhsElems[rhsIdx] = true;
                        break;
                    }
                }
                if (rhsIdx >= rhsCount)
                {
                    // no matching elem found
                    return false;
                }
            }

            return true;
        }

        public static string IntMaxString(int value)
        {
            return (value == Int32.MaxValue) ? "" : "" + value;
        }

        public static string LongMaxString(long value)
        {
            return (value == Int64.MaxValue) ? "" : "" + value;
        }

        public static string DoubleMaxString(double value)
        {
            return (value == Double.MaxValue) ? "" : "" + value;
        }

        public static string UnixSecondsToString(long seconds, string format)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(seconds)).ToString(format);
        }

        public static string formatDoubleString(String str)
        {
            return String.IsNullOrEmpty(str) ? "" : String.Format("{0,0:N2}", Double.Parse(str));
        }

        public static string TagValueListToString(List<TagValue> options)
        {
            StringBuilder tagValuesStr = new StringBuilder();
            int tagValuesCount = options == null ? 0 : options.Count;

            for (int i = 0; i < tagValuesCount; i++)
            {
                TagValue tagValue = options[i];
                tagValuesStr.Append(tagValue.Tag).Append("=").Append(tagValue.Value).Append(";");
            }

            return tagValuesStr.ToString();
        }
    }
}
