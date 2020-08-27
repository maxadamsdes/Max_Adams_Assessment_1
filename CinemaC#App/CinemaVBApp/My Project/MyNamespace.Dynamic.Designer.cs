using CinemaCSharpApp;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace CinemaVBApp.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form m_Form;

            public Form Form
            {
                [DebuggerHidden]
                get
                {
                    m_Form = Create__Instance__(m_Form);
                    return m_Form;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form);
                }
            }
        }
    }
}