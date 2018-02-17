﻿// <copyright file="testrunTestsuite.cs" company="Automate The Planet Ltd.">
// Copyright 2018 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://automatetheplanet.com/</site>

// <auto-generated/>
// ReSharper disable All
using System.Xml.Serialization;

namespace Meissa.Core.Model.NUnit
{
    [XmlType(AnonymousType = true)]
    public class testrunTestsuite
    {
        private testrunTestsuiteEnvironment _environmentField;

        private testrunTestsuiteSetting[] _settingsField;

        private testrunTestsuiteProperty[] _propertiesField;

        private testrunTestsuiteFailure _failureField;

        private testrunTestsuiteTestsuite[] _testsuiteField;

        private string _typeField;

        private string _idField;

        private string _nameField;

        private string _fullnameField;

        private string _runstateField;

        private int _testcasecountField;

        private string _resultField;

        private string _siteField;

        private string _starttimeField;

        private string _endtimeField;

        private decimal _durationField;

        private int _totalField;

        private int _passedField;

        private int _failedField;

        private int _warningsField;

        private int _inconclusiveField;

        private int _skippedField;

        private int _assertsField;

        public testrunTestsuiteEnvironment environment
        {
            get
            {
                return _environmentField;
            }
            set
            {
                _environmentField = value;
            }
        }

        [XmlArrayItem("setting", IsNullable = false)]
        public testrunTestsuiteSetting[] settings
        {
            get
            {
                return _settingsField;
            }
            set
            {
                _settingsField = value;
            }
        }

        [XmlArrayItem("property", IsNullable = false)]
        public testrunTestsuiteProperty[] properties
        {
            get
            {
                return _propertiesField;
            }
            set
            {
                _propertiesField = value;
            }
        }

        public testrunTestsuiteFailure failure
        {
            get
            {
                return _failureField;
            }
            set
            {
                _failureField = value;
            }
        }

        [XmlElement("test-suite")]
        public testrunTestsuiteTestsuite[] testsuite
        {
            get
            {
                return _testsuiteField;
            }
            set
            {
                _testsuiteField = value;
            }
        }

        [XmlAttribute]
        public string type
        {
            get
            {
                return _typeField;
            }
            set
            {
                _typeField = value;
            }
        }

        [XmlAttribute]
        public string id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

        [XmlAttribute]
        public string fullname
        {
            get
            {
                return _fullnameField;
            }
            set
            {
                _fullnameField = value;
            }
        }

        [XmlAttribute]
        public string runstate
        {
            get
            {
                return _runstateField;
            }
            set
            {
                _runstateField = value;
            }
        }

        [XmlAttribute]
        public int testcasecount
        {
            get
            {
                return _testcasecountField;
            }
            set
            {
                _testcasecountField = value;
            }
        }

        [XmlAttribute]
        public string result
        {
            get
            {
                return _resultField;
            }
            set
            {
                _resultField = value;
            }
        }

        [XmlAttribute]
        public string site
        {
            get
            {
                return _siteField;
            }
            set
            {
                _siteField = value;
            }
        }

        [XmlAttribute("start-time")]
        public string starttime
        {
            get
            {
                return _starttimeField;
            }
            set
            {
                _starttimeField = value;
            }
        }

        [XmlAttribute("end-time")]
        public string endtime
        {
            get
            {
                return _endtimeField;
            }
            set
            {
                _endtimeField = value;
            }
        }

        [XmlAttribute]
        public decimal duration
        {
            get
            {
                return _durationField;
            }
            set
            {
                _durationField = value;
            }
        }

        [XmlAttribute]
        public int total
        {
            get
            {
                return _totalField;
            }
            set
            {
                _totalField = value;
            }
        }

        [XmlAttribute]
        public int passed
        {
            get
            {
                return _passedField;
            }
            set
            {
                _passedField = value;
            }
        }

        [XmlAttribute]
        public int failed
        {
            get
            {
                return _failedField;
            }
            set
            {
                _failedField = value;
            }
        }

        [XmlAttribute]
        public int warnings
        {
            get
            {
                return _warningsField;
            }
            set
            {
                _warningsField = value;
            }
        }

        [XmlAttribute]
        public int inconclusive
        {
            get
            {
                return _inconclusiveField;
            }
            set
            {
                _inconclusiveField = value;
            }
        }

        [XmlAttribute]
        public int skipped
        {
            get
            {
                return _skippedField;
            }
            set
            {
                _skippedField = value;
            }
        }

        [XmlAttribute]
        public int asserts
        {
            get
            {
                return _assertsField;
            }
            set
            {
                _assertsField = value;
            }
        }
    }
}

// ReSharper restore All