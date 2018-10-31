/*
 * Grade ID: A4431
 * Progam 4
 * Due: 12/5/2017
 * Section 01
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook
    {
        private string _title;//backing field for Title
        private string _author;//Backing field for Author
        private string _publisher;//Backing field for Publisher
        private string _callnum;//Backing field for CallNum

        private int _copyrightyear;//Backing field for CopyRightYear

        private bool _checkedout = false;//Books are automatically not checked out therefore it is set to false

        //Pre-condition: None
        //Post-condition: return Title
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //Pre-condition: None
        //Post-condition: return author
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        //Pre-Condition: None
        //Post-condition: return publisher
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        //Pre-condtion: none
        //Post-condtion: return call number
        public string CallNum
        {
            get { return _callnum; }
            set { _callnum = value; }
        }

        //Pre-condition: the value for copyright year > 0
        //Post-condition: return value for copyright year
        public int CopyRightYear
        {
            get
            {
                return _copyrightyear;
            }
            set
            {
                if (value <= 0)//if copyright year is negative or equal to zero the year will be set to 2017
                {
                    _copyrightyear = 2017;
                }
                else
                    _copyrightyear = value;
            }

        }

        //Pre-condition: the book shouldn't be checked out AKA _checkedout ==false
        //Post-Condition: the book should be checked out AKA change _checkedout to true
        public void CheckOut()
        {
            if (_checkedout == false)
            {
                _checkedout = true;
            }
        }

        //Pre-condition: book should be checked out AKA _checkedout == true
        //Post-condition: _checkedout == false and book isn't checked out
        public void ReturnToShelf()
        {
            if (_checkedout == true)
            {
                _checkedout = false;
            }
        }

        //Pre-condition: None
        //Post-condition: return value of true or false
        public bool IsCheckedOut()
        {
            if (_checkedout == false)
            {
                return false;
            }
            else
                return true;
        }

        //constructor for Librarybook
        //Pre-condition: every book needs a titel, author, publisher, call number, and copyright year
        //Post-condition: A LibraryBook will be initialized with a title, author, publisher, call number, and copyright year
        public LibraryBook(string title, string author, string publisher, string callnum, int copyrightyear)
        {
            Title = title;//set using Title property
            Author = author;// set using Author property
            Publisher = publisher; //set using Publisher property
            CallNum = callnum;// set using CallNum property
            CopyRightYear = copyrightyear;//set using CopyRightYear property


        }

        //Represents data as a string to the Console
        public override string ToString()
        {
            return $"Title:             {Title} {Environment.NewLine}"
                + $"Author:             {Author} {Environment.NewLine}"
                + $"Publisher:          {Publisher} {Environment.NewLine}" +
                $"Call number:         {CallNum}{Environment.NewLine}" +
                $"Copyright Year:     {CopyRightYear}{Environment.NewLine}" +
                $"Checked out:         {IsCheckedOut()}";
        }
    }
}

