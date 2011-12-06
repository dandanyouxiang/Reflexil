/* Reflexil Copyright (c) 2007-2011 Sebastien LEBRETON

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. */

#region " Imports "
using System.ComponentModel;
using System.Windows.Forms;
using Mono.Cecil;
#endregion

namespace Reflexil.Forms
{
	public partial class CustomAttributeArgumentForm: Form
    {

        #region " Fields "
        private CustomAttributeArgument m_argument;
        private CustomAttribute m_attribute;
        #endregion

        #region " Properties "
        public CustomAttributeArgument Argument
        {
            get
            {
                return m_argument;
            }
        }

        public CustomAttribute Attribute
        {
            get
            {
                return m_attribute;
            }
        }

        protected bool IsFormComplete
        {
            get
            {
                foreach (Control ctl in Controls)
                {
                    ctl.Focus();
                    if (!Validate()) return false;
                }
                return true;
            }
        }
        #endregion

        #region " Methods "
        public CustomAttributeArgumentForm()
        {
            InitializeComponent();
        }

        public virtual DialogResult ShowDialog(CustomAttribute attribute, CustomAttributeArgument argument)
        {
            m_argument = argument;
            m_attribute = attribute;
            return base.ShowDialog();
        }
        #endregion

        #region " Events "
        #endregion

	}
}