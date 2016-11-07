﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Dealership.XmlFilesProcessing.Writers.Contracts;

namespace Dealership.XmlFilesProcessing.Writers.Common
{
    public abstract class XmlReportWriter : IReportWriter
    {
        protected readonly string Url;
        protected XmlWriterSettings Settings;

        protected XmlReportWriter()
        {
            this.Url = "../../../../Reports/Xml-Reports";
            this.Settings = new XmlWriterSettings();

            Settings.Encoding = Encoding.UTF8;
            Settings.Indent = true;
            Settings.IndentChars = "\t";
        }

        public abstract void Write();
    }
}
