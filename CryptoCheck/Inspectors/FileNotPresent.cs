﻿using System;
using System.Collections.Generic;
using CryptoCheck.Ex;

namespace CryptoCheck.Inspectors
{
    /// <summary>
    /// Determines if a file is present, reporting a jailbreak if it is.
    /// </summary>
    public class FileNotPresent : InspectorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cryoprison.Inspectors.FileNotPresent"/> class.
        /// </summary>
        public FileNotPresent()
            : base("FILE_{0}_SHOULD_NOT_BE_PRESENT")
        {
        }

        /// <summary>
        /// Returns true if the file identified by 'val' during initialization
        /// can not be created, written to and deleted.
        /// </summary>
        public override bool Ok
        {
            get
            {
                return !IsFilePresent(this.val);
            }
        }

        /// <summary>
        /// Determines if the file is in deed present
        /// </summary>
        /// <param name="path">The full path of the file.</param>
        public bool IsFilePresent(string path)
        {
            try
            {
                return Env.System.IO.File.Exists(path);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                return false;
            }
            catch (Exception ex)
            {
                ReportException($"IsFilePresent bombed for {path}", ex);
                return false;
            }
        }
    }
}
