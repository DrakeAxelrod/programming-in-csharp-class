//Farid Naisan

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Email
{
    //private email
    private string personalMail;
    //officeMail mail
    private string officeMail;

    //Constructors are overloaded and called in a chain

    /// <summary>
    /// Default constructor - calls another constructor in this class
    /// </summary>
    /// <remarks></remarks>
    public Email()
    {
    }

    /// <summary>
    /// Constructor with one parameter - calls the constructor with 
    /// two parameters, using a default value as the second argument.
    /// </summary>
    /// <param name="workMail">input coming from the client object</param>
    /// <remarks></remarks>
    public Email(string workMail) : this(workMail, string.Empty)
    {
    }
    /// <summary>
    /// Copy constructor returning copy
    /// </summary>
    public Email(Email theOther)
    {
        this.personalMail = theOther.personalMail;
        this.officeMail = theOther.officeMail;
    }
    /// <summary>
    /// Constructor with two parameters. This is  constructor that has most
    /// number of parameters. It is in tis constructor that all coding 
    /// should be done.
    /// </summary>
    /// <param name="workMail">Input - office mail</param>
    /// <param name="personalMail">Input - private mail</param>
    /// <remarks></remarks>
    public Email(string workMail, string personalMail)
    {
        officeMail = workMail;
        this.personalMail = personalMail;
    }

    /// <summary>
    /// Property related to the field m_Personal
    /// Both read and write access
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string Personal
    {
        //private mail
        get { return personalMail; }

        set { personalMail = value; }
    }


    /// <summary>
    /// Property related to officeMail field
    /// Both read and write access
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    public string Work
    {
        get { return officeMail; }

        set { officeMail = value; }
    }

    /// <summary>
    /// This method prepares a format string that is in sync with the ToString
    /// method.  It will be used in the MainForm as part of the heading for the ListBox
    /// before customer information is added in the ListBox.
    /// </summary>
    /// <value></value>
    /// <returns>A formatted string as heading for the values formatted in the ToString
    /// method below.</returns>
    /// <remarks></remarks>
    public string GetToStringItemsHeadings
    {
        get { return string.Format("{0,-20} {1, -20}", "Office EmailData", "Private EmailData"); }
    }

    /// <summary>
    /// Delivers a formatted string with data stored in the object. The values will
    /// appear as columns.  Make sure that a font like "Courier New" is used in
    /// the control displaying this information.
    /// </summary>
    /// <returns>the Formatted strings.</returns>
    /// <remarks></remarks>
    public override string ToString()
    {
        string strOut = "\n" + "Emails" + "\n";

        strOut += string.Format(" {0,-10} {1, -10}\n", "Private", personalMail);
        strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", officeMail);

        return strOut;
    }

}







