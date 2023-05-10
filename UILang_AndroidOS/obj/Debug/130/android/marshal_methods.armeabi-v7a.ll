; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [170 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 42
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 64
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 4
	i32 134690465, ; 3: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 68
	i32 165246403, ; 4: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 21
	i32 209399409, ; 5: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 19
	i32 230216969, ; 6: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 38
	i32 232815796, ; 7: System.Web.Services => 0xde07cb4 => 82
	i32 261689757, ; 8: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 24
	i32 280482487, ; 9: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 37
	i32 318968648, ; 10: Xamarin.AndroidX.Activity.dll => 0x13031348 => 12
	i32 321597661, ; 11: System.Numerics => 0x132b30dd => 8
	i32 342366114, ; 12: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 39
	i32 441335492, ; 13: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 23
	i32 442521989, ; 14: Xamarin.Essentials => 0x1a605985 => 61
	i32 450948140, ; 15: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 36
	i32 465846621, ; 16: mscorlib => 0x1bc4415d => 3
	i32 469710990, ; 17: System.dll => 0x1bff388e => 6
	i32 476646585, ; 18: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 37
	i32 486930444, ; 19: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 46
	i32 526420162, ; 20: System.Transactions.dll => 0x1f6088c2 => 75
	i32 527452488, ; 21: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 68
	i32 605376203, ; 22: System.IO.Compression.FileSystem => 0x24154ecb => 78
	i32 627609679, ; 23: Xamarin.AndroidX.CustomView => 0x2568904f => 29
	i32 639843206, ; 24: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 35
	i32 663517072, ; 25: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 58
	i32 666292255, ; 26: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 17
	i32 690569205, ; 27: System.Xml.Linq.dll => 0x29293ff5 => 83
	i32 691348768, ; 28: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 70
	i32 700284507, ; 29: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 65
	i32 720511267, ; 30: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 69
	i32 775507847, ; 31: System.IO.Compression => 0x2e394f87 => 77
	i32 790371945, ; 32: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 30
	i32 809851609, ; 33: System.Drawing.Common.dll => 0x30455ad9 => 72
	i32 843511501, ; 34: Xamarin.AndroidX.Print => 0x3246f6cd => 48
	i32 928116545, ; 35: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 64
	i32 955402788, ; 36: Newtonsoft.Json => 0x38f24a24 => 4
	i32 956575887, ; 37: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 69
	i32 967690846, ; 38: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 39
	i32 1012816738, ; 39: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 52
	i32 1031528504, ; 40: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 63
	i32 1035644815, ; 41: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 16
	i32 1052210849, ; 42: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 43
	i32 1084122840, ; 43: Xamarin.Kotlin.StdLib => 0x409e66d8 => 67
	i32 1098259244, ; 44: System => 0x41761b2c => 6
	i32 1175144683, ; 45: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 56
	i32 1204270330, ; 46: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 17
	i32 1264511973, ; 47: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 53
	i32 1267360935, ; 48: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 57
	i32 1275534314, ; 49: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 70
	i32 1293217323, ; 50: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 32
	i32 1365406463, ; 51: System.ServiceModel.Internals.dll => 0x516272ff => 81
	i32 1376866003, ; 52: Xamarin.AndroidX.SavedState => 0x52114ed3 => 52
	i32 1406073936, ; 53: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 25
	i32 1462112819, ; 54: System.IO.Compression.dll => 0x57261233 => 77
	i32 1469204771, ; 55: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 15
	i32 1582372066, ; 56: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 31
	i32 1592978981, ; 57: System.Runtime.Serialization.dll => 0x5ef2ee25 => 80
	i32 1597949149, ; 58: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 63
	i32 1622152042, ; 59: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 45
	i32 1624863272, ; 60: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 60
	i32 1635184631, ; 61: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 35
	i32 1636350590, ; 62: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 28
	i32 1639515021, ; 63: System.Net.Http.dll => 0x61b9038d => 7
	i32 1657153582, ; 64: System.Runtime => 0x62c6282e => 10
	i32 1658241508, ; 65: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 54
	i32 1658251792, ; 66: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 62
	i32 1670060433, ; 67: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 24
	i32 1698840827, ; 68: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 66
	i32 1729485958, ; 69: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 20
	i32 1776026572, ; 70: System.Core.dll => 0x69dc03cc => 5
	i32 1788241197, ; 71: Xamarin.AndroidX.Fragment => 0x6a96652d => 36
	i32 1808609942, ; 72: Xamarin.AndroidX.Loader => 0x6bcd3296 => 45
	i32 1813058853, ; 73: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 67
	i32 1813201214, ; 74: Xamarin.Google.Android.Material => 0x6c13413e => 62
	i32 1867746548, ; 75: Xamarin.Essentials.dll => 0x6f538cf4 => 61
	i32 1885316902, ; 76: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 18
	i32 1919157823, ; 77: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 47
	i32 1983156543, ; 78: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 66
	i32 2019465201, ; 79: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 43
	i32 2055257422, ; 80: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 40
	i32 2079903147, ; 81: System.Runtime.dll => 0x7bf8cdab => 10
	i32 2090596640, ; 82: System.Numerics.Vectors => 0x7c9bf920 => 9
	i32 2201107256, ; 83: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 71
	i32 2201231467, ; 84: System.Net.Http => 0x8334206b => 7
	i32 2217644978, ; 85: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 56
	i32 2244775296, ; 86: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 46
	i32 2256548716, ; 87: Xamarin.AndroidX.MultiDex => 0x8680336c => 47
	i32 2279755925, ; 88: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 50
	i32 2315684594, ; 89: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 13
	i32 2403452196, ; 90: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 34
	i32 2465532216, ; 91: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 23
	i32 2471841756, ; 92: netstandard.dll => 0x93554fdc => 73
	i32 2475788418, ; 93: Java.Interop.dll => 0x93918882 => 1
	i32 2501346920, ; 94: System.Data.DataSetExtensions => 0x95178668 => 76
	i32 2505896520, ; 95: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 42
	i32 2581819634, ; 96: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 57
	i32 2605712449, ; 97: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 71
	i32 2620871830, ; 98: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 28
	i32 2624644809, ; 99: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 33
	i32 2701096212, ; 100: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 54
	i32 2732626843, ; 101: Xamarin.AndroidX.Activity => 0xa2e0939b => 12
	i32 2737747696, ; 102: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 15
	i32 2770495804, ; 103: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 65
	i32 2778768386, ; 104: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 59
	i32 2779977773, ; 105: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 51
	i32 2810250172, ; 106: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 25
	i32 2819470561, ; 107: System.Xml.dll => 0xa80db4e1 => 11
	i32 2821294376, ; 108: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 51
	i32 2853208004, ; 109: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 59
	i32 2855708567, ; 110: Xamarin.AndroidX.Transition => 0xaa36a797 => 55
	i32 2903344695, ; 111: System.ComponentModel.Composition => 0xad0d8637 => 79
	i32 2905242038, ; 112: mscorlib.dll => 0xad2a79b6 => 3
	i32 2916838712, ; 113: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 60
	i32 2919462931, ; 114: System.Numerics.Vectors.dll => 0xae037813 => 9
	i32 2921128767, ; 115: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 14
	i32 2971102757, ; 116: UILang_AndroidOS => 0xb1176e25 => 0
	i32 2978675010, ; 117: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 32
	i32 2996846495, ; 118: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 41
	i32 3016983068, ; 119: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 53
	i32 3024354802, ; 120: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 38
	i32 3111772706, ; 121: System.Runtime.Serialization => 0xb979e222 => 80
	i32 3204380047, ; 122: System.Data.dll => 0xbefef58f => 74
	i32 3211777861, ; 123: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 31
	i32 3247949154, ; 124: Mono.Security => 0xc197c562 => 84
	i32 3258312781, ; 125: Xamarin.AndroidX.CardView => 0xc235e84d => 20
	i32 3317135071, ; 126: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 29
	i32 3317144872, ; 127: System.Data => 0xc5b79d28 => 74
	i32 3340431453, ; 128: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 18
	i32 3345895724, ; 129: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 49
	i32 3362522851, ; 130: Xamarin.AndroidX.Core => 0xc86c06e3 => 27
	i32 3366347497, ; 131: Java.Interop => 0xc8a662e9 => 1
	i32 3374999561, ; 132: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 50
	i32 3404865022, ; 133: System.ServiceModel.Internals => 0xcaf21dfe => 81
	i32 3405233483, ; 134: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 30
	i32 3429136800, ; 135: System.Xml => 0xcc6479a0 => 11
	i32 3430777524, ; 136: netstandard => 0xcc7d82b4 => 73
	i32 3441283291, ; 137: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 33
	i32 3476120550, ; 138: Mono.Android => 0xcf3163e6 => 2
	i32 3486566296, ; 139: System.Transactions => 0xcfd0c798 => 75
	i32 3493954962, ; 140: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 22
	i32 3509114376, ; 141: System.Xml.Linq => 0xd128d608 => 83
	i32 3567349600, ; 142: System.ComponentModel.Composition.dll => 0xd4a16f60 => 79
	i32 3627220390, ; 143: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 48
	i32 3633644679, ; 144: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 14
	i32 3641597786, ; 145: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 40
	i32 3672681054, ; 146: Mono.Android.dll => 0xdae8aa5e => 2
	i32 3676310014, ; 147: System.Web.Services.dll => 0xdb2009fe => 82
	i32 3682565725, ; 148: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 19
	i32 3684561358, ; 149: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 22
	i32 3689375977, ; 150: System.Drawing.Common => 0xdbe768e9 => 72
	i32 3706696989, ; 151: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 26
	i32 3718780102, ; 152: Xamarin.AndroidX.Annotation => 0xdda814c6 => 13
	i32 3786282454, ; 153: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 21
	i32 3829621856, ; 154: System.Numerics.dll => 0xe4436460 => 8
	i32 3885922214, ; 155: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 55
	i32 3888767677, ; 156: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 49
	i32 3896760992, ; 157: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 27
	i32 3920810846, ; 158: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 78
	i32 3921031405, ; 159: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 58
	i32 3945713374, ; 160: System.Data.DataSetExtensions.dll => 0xeb2ecede => 76
	i32 3955647286, ; 161: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 16
	i32 3959773229, ; 162: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 41
	i32 4101593132, ; 163: Xamarin.AndroidX.Emoji2 => 0xf479582c => 34
	i32 4105002889, ; 164: Mono.Security.dll => 0xf4ad5f89 => 84
	i32 4134420312, ; 165: UILang_AndroidOS.dll => 0xf66e3f58 => 0
	i32 4151237749, ; 166: System.Core => 0xf76edc75 => 5
	i32 4182413190, ; 167: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 44
	i32 4256097574, ; 168: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 26
	i32 4292120959 ; 169: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 44
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [170 x i32] [
	i32 42, i32 64, i32 4, i32 68, i32 21, i32 19, i32 38, i32 82, ; 0..7
	i32 24, i32 37, i32 12, i32 8, i32 39, i32 23, i32 61, i32 36, ; 8..15
	i32 3, i32 6, i32 37, i32 46, i32 75, i32 68, i32 78, i32 29, ; 16..23
	i32 35, i32 58, i32 17, i32 83, i32 70, i32 65, i32 69, i32 77, ; 24..31
	i32 30, i32 72, i32 48, i32 64, i32 4, i32 69, i32 39, i32 52, ; 32..39
	i32 63, i32 16, i32 43, i32 67, i32 6, i32 56, i32 17, i32 53, ; 40..47
	i32 57, i32 70, i32 32, i32 81, i32 52, i32 25, i32 77, i32 15, ; 48..55
	i32 31, i32 80, i32 63, i32 45, i32 60, i32 35, i32 28, i32 7, ; 56..63
	i32 10, i32 54, i32 62, i32 24, i32 66, i32 20, i32 5, i32 36, ; 64..71
	i32 45, i32 67, i32 62, i32 61, i32 18, i32 47, i32 66, i32 43, ; 72..79
	i32 40, i32 10, i32 9, i32 71, i32 7, i32 56, i32 46, i32 47, ; 80..87
	i32 50, i32 13, i32 34, i32 23, i32 73, i32 1, i32 76, i32 42, ; 88..95
	i32 57, i32 71, i32 28, i32 33, i32 54, i32 12, i32 15, i32 65, ; 96..103
	i32 59, i32 51, i32 25, i32 11, i32 51, i32 59, i32 55, i32 79, ; 104..111
	i32 3, i32 60, i32 9, i32 14, i32 0, i32 32, i32 41, i32 53, ; 112..119
	i32 38, i32 80, i32 74, i32 31, i32 84, i32 20, i32 29, i32 74, ; 120..127
	i32 18, i32 49, i32 27, i32 1, i32 50, i32 81, i32 30, i32 11, ; 128..135
	i32 73, i32 33, i32 2, i32 75, i32 22, i32 83, i32 79, i32 48, ; 136..143
	i32 14, i32 40, i32 2, i32 82, i32 19, i32 22, i32 72, i32 26, ; 144..151
	i32 13, i32 21, i32 8, i32 55, i32 49, i32 27, i32 78, i32 58, ; 152..159
	i32 76, i32 16, i32 41, i32 34, i32 84, i32 0, i32 5, i32 44, ; 160..167
	i32 26, i32 44 ; 168..169
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
