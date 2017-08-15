using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace WinFileUtils
{
    public class WinFileNode
    {
        private WinFileNode parent = null;
        private List<WinFileNode> children = null;

        public WinFileNode()
        {
            parent = null;
            children = null;
        }

    }
}
