﻿using AddressBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.DataAccess
{
    public interface IDataConnection
    {
        EntryModel SaveEntry(EntryModel entry);
    }
}