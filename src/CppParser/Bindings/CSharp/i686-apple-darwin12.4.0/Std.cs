// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

namespace Std
{
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
    namespace Allocator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class Allocator<_Tp> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Tp>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Tp>>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.Allocator<_Tp> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Tp>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.Allocator<_Tp> __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Tp>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            *(global::Std.Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.Allocator<_Tp> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    namespace CompressedPair
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public unsafe partial struct __Internal
        {
        }
    }
}

namespace Std
{
    namespace Vector
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_PreprocessedEntity___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Declaration___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_BlockContentComment___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Namespace___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Enumeration___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Function___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Class___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Template___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_TypedefDecl___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_TypeAlias___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Variable___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Friend___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_BaseClassSpecifier___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Field___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Method___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Parameter___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_FunctionTemplateSpecialization___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_TemplateArgument___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_AccessSpecifierDecl___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_VFTableInfo___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_VTableComponent___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_LayoutField___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_LayoutBase___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Enumeration_S_Item___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_std_N___1_S_basic_string__C___N_std_N___1_S_char_traits__C___N_std_N___1_S_allocator__C___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internal __begin_;

            [FieldOffset(4)]
            internal global::Std.BasicString.__Internal __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_ClassTemplateSpecialization___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_ExpressionObsolete___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_VarTemplateSpecialization___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_MacroDefinition___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_TranslationUnit___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Stmt___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_Expr___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_InlineContentComment___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_BlockCommandComment_S_Argument___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector__i___N_std_N___1_S_allocator__i
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector_____N_CppSharp_N_CppParser_N_AST_S_VerbatimBlockLineComment___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_InlineCommandComment_S_Argument___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_N_AST_S_HTMLStartTagComment_S_Attribute___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_N___1_S_vector____N_CppSharp_N_CppParser_S_ParserDiagnostic___N_std_N___1_S_allocator__S0_
        {
            [FieldOffset(0)]
            internal global::System.IntPtr __begin_;

            [FieldOffset(4)]
            internal global::System.IntPtr __end_;

            [FieldOffset(8)]
            internal global::Std.CompressedPair.__Internal __end_cap_;
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace Map
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internal
        {
        }
    }
}

namespace Std
{
    namespace BasicString
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEEC2Ev")]
            internal static extern void ctorc__N_std_N___1_S_basic_string__C___N_std_N___1_S_char_traits__C___N_std_N___1_S_allocator__C(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEED2Ev")]
            internal static extern void dtorc__N_std_N___1_S_basic_string__C___N_std_N___1_S_char_traits__C___N_std_N___1_S_allocator__C(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNKSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEE5c_strEv")]
            internal static extern global::System.IntPtr CStrc__N_std_N___1_S_basic_string__C___N_std_N___1_S_char_traits__C___N_std_N___1_S_allocator__C(global::System.IntPtr __instance);
        }
    }

    public unsafe partial class BasicString<_CharT, _Traits, _Allocator> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_CharT, _Traits, _Allocator>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_CharT, _Traits, _Allocator>>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.BasicString<_CharT, _Traits, _Allocator> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.BasicString<_CharT, _Traits, _Allocator>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.BasicString<_CharT, _Traits, _Allocator> __CreateInstance(global::Std.BasicString.__Internal native, bool skipVTables = false)
        {
            return new global::Std.BasicString<_CharT, _Traits, _Allocator>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.BasicString.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internal));
            *(global::Std.BasicString.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private BasicString(global::Std.BasicString.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected BasicString(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public BasicString()
        {
            var ___CharT = typeof(_CharT);
            var ___Traits = typeof(_Traits);
            var ___Allocator = typeof(_Allocator);
            if (___CharT.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Allocator.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                global::Std.BasicString.__Internal.ctorc__N_std_N___1_S_basic_string__C___N_std_N___1_S_char_traits__C___N_std_N___1_S_allocator__C((__Instance + __PointerAdjustment));
                return;
            }
            throw new ArgumentOutOfRangeException("_CharT, _Traits, _Allocator", string.Join(", ", new[] { typeof(_CharT).FullName, typeof(_Traits).FullName, typeof(_Allocator).FullName }), "global::Std.BasicString<_CharT, _Traits, _Allocator> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.BasicString<_CharT, _Traits, _Allocator> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
            {
                var ___CharT = typeof(_CharT);
                var ___Traits = typeof(_Traits);
                var ___Allocator = typeof(_Allocator);
                if (___CharT.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Allocator.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
                {
                    global::Std.BasicString.__Internal.dtorc__N_std_N___1_S_basic_string__C___N_std_N___1_S_char_traits__C___N_std_N___1_S_allocator__C((__Instance + __PointerAdjustment));
                    return;
                }
                throw new ArgumentOutOfRangeException("_CharT, _Traits, _Allocator", string.Join(", ", new[] { typeof(_CharT).FullName, typeof(_Traits).FullName, typeof(_Allocator).FullName }), "global::Std.BasicString<_CharT, _Traits, _Allocator> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::Std.BasicString<_CharT, _Traits, _Allocator> Assign(global::Std.BasicString<_CharT, _Traits, _Allocator> str)
        {
            var ___CharT = typeof(_CharT);
            var ___Traits = typeof(_Traits);
            var ___Allocator = typeof(_Allocator);
            if (___CharT.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Allocator.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
            {
                throw new MissingMethodException("Method Assign ignored in specialization global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
            }
            throw new ArgumentOutOfRangeException("_CharT, _Traits, _Allocator", string.Join(", ", new[] { typeof(_CharT).FullName, typeof(_Traits).FullName, typeof(_Allocator).FullName }), "global::Std.BasicString<_CharT, _Traits, _Allocator> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
        }
    }

    namespace CharTraits
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class CharTraits<_CharT> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_CharT>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_CharT>>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.CharTraits<_CharT> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_CharT>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.CharTraits<_CharT> __CreateInstance(global::Std.CharTraits.__Internal native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_CharT>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            *(global::Std.CharTraits.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CharTraits(global::Std.CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.CharTraits<_CharT> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    public unsafe static partial class BasicStringExtensions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEE6assignEPKc")]
            internal static extern global::System.IntPtr Assign(global::System.IntPtr __instance, [MarshalAs(UnmanagedType.LPStr)] string __s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNKSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEE5c_strEv")]
            internal static extern global::System.IntPtr CStr(global::System.IntPtr __instance);
        }

        public static global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> Assign(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this, string __s)
        {
            var __arg0 = ReferenceEquals(@this, null) ? global::System.IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.Assign(__arg0, __s);
            global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>) global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap[__ret];
            else __result0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
            return __result0;
        }

        public static string CStr(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this)
        {
            var __arg0 = ReferenceEquals(@this, null) ? global::System.IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.CStr(__arg0);
            return Marshal.PtrToStringAnsi(__ret);
        }
    }
}
