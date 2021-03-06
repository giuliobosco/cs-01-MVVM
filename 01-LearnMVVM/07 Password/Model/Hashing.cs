﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _07_Password.Helper;

namespace _07_Password.Model {
    public class Hashing {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        private string hash;

        public string Hash {
            get { return hash; }
            set { hash = value; }
        }

        private string plainText;

        public string PlainText {
            get { return plainText; }
            set { plainText = value; }
        }

        private string salt;

        public string Salt {
            get { return salt; }
            set { salt = value; }
        }

        #endregion

        #region =================== constructors ===============

        public Hashing() { }

        #endregion

        #region =================== help methods ===============

        #endregion

        #region =================== general methods ============

        public void ComputeHash() {
            UTF8Encoding utf8 = new UTF8Encoding();

            byte[] textWithSaltBytes = utf8.GetBytes(string.Concat(PlainText, Salt));

            HashAlgorithm hasher = new SHA1CryptoServiceProvider();
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);

            hasher.Clear();
            Hash = (string) new BytesToStringConverter().Convert(hashedBytes, null, null, null);
        }

        #endregion
    }
}
