using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HFC_Duck_And_Cover
{
    class Duck//: IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

    /*    public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }*/

        public enum KindOfDuck
        {
            Mallard,
            Muscovy,
            Loon,
            Peking
        }

 
    }

    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }

    class DuckComparer: IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

    public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                    return 0;
            }
            else if (SortBy == SortCriteria.KindThenSize)
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                    return 0;
            }
            //This superfulous else statement allows us to add new things to compare in the future.
            else 
                return 0;
        }
    }
}
