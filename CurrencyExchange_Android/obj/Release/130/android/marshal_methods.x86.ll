; ModuleID = 'obj\Release\130\android\marshal_methods.x86.ll'
source_filename = "obj\Release\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [56 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 23
	i32 39109920, ; 1: Newtonsoft.Json.dll => 0x254c520 => 5
	i32 230752869, ; 2: Microsoft.CSharp.dll => 0xdc10265 => 2
	i32 318968648, ; 3: Xamarin.AndroidX.Activity.dll => 0x13031348 => 11
	i32 321597661, ; 4: System.Numerics => 0x132b30dd => 9
	i32 342366114, ; 5: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 17
	i32 442521989, ; 6: Xamarin.Essentials => 0x1a605985 => 22
	i32 450948140, ; 7: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 16
	i32 465846621, ; 8: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 9: System.dll => 0x1bff388e => 7
	i32 627609679, ; 10: Xamarin.AndroidX.CustomView => 0x2568904f => 14
	i32 690569205, ; 11: System.Xml.Linq.dll => 0x29293ff5 => 26
	i32 928116545, ; 12: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 23
	i32 955402788, ; 13: Newtonsoft.Json => 0x38f24a24 => 5
	i32 967690846, ; 14: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 17
	i32 1012816738, ; 15: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 21
	i32 1035644815, ; 16: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 12
	i32 1052210849, ; 17: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 19
	i32 1098259244, ; 18: System => 0x41761b2c => 7
	i32 1293217323, ; 19: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 15
	i32 1376866003, ; 20: Xamarin.AndroidX.SavedState => 0x52114ed3 => 21
	i32 1592978981, ; 21: System.Runtime.Serialization.dll => 0x5ef2ee25 => 25
	i32 1622152042, ; 22: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 20
	i32 1639515021, ; 23: System.Net.Http.dll => 0x61b9038d => 8
	i32 1776026572, ; 24: System.Core.dll => 0x69dc03cc => 6
	i32 1788241197, ; 25: Xamarin.AndroidX.Fragment => 0x6a96652d => 16
	i32 1808609942, ; 26: Xamarin.AndroidX.Loader => 0x6bcd3296 => 20
	i32 1867746548, ; 27: Xamarin.Essentials.dll => 0x6f538cf4 => 22
	i32 2019465201, ; 28: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 19
	i32 2055257422, ; 29: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 18
	i32 2201231467, ; 30: System.Net.Http => 0x8334206b => 8
	i32 2267774398, ; 31: CurrencyExchange_Android.dll => 0x872b7dbe => 0
	i32 2475788418, ; 32: Java.Interop.dll => 0x93918882 => 1
	i32 2522274025, ; 33: CurrencyExchange_Android => 0x9656d8e9 => 0
	i32 2562349572, ; 34: Microsoft.CSharp => 0x98ba5a04 => 2
	i32 2732626843, ; 35: Xamarin.AndroidX.Activity => 0xa2e0939b => 11
	i32 2819470561, ; 36: System.Xml.dll => 0xa80db4e1 => 10
	i32 2905242038, ; 37: mscorlib.dll => 0xad2a79b6 => 4
	i32 2978675010, ; 38: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 15
	i32 3111772706, ; 39: System.Runtime.Serialization => 0xb979e222 => 25
	i32 3204380047, ; 40: System.Data.dll => 0xbefef58f => 24
	i32 3247949154, ; 41: Mono.Security => 0xc197c562 => 27
	i32 3317135071, ; 42: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 14
	i32 3317144872, ; 43: System.Data => 0xc5b79d28 => 24
	i32 3362522851, ; 44: Xamarin.AndroidX.Core => 0xc86c06e3 => 13
	i32 3366347497, ; 45: Java.Interop => 0xc8a662e9 => 1
	i32 3429136800, ; 46: System.Xml => 0xcc6479a0 => 10
	i32 3476120550, ; 47: Mono.Android => 0xcf3163e6 => 3
	i32 3509114376, ; 48: System.Xml.Linq => 0xd128d608 => 26
	i32 3641597786, ; 49: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 18
	i32 3672681054, ; 50: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3829621856, ; 51: System.Numerics.dll => 0xe4436460 => 9
	i32 3896760992, ; 52: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 13
	i32 3955647286, ; 53: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 12
	i32 4105002889, ; 54: Mono.Security.dll => 0xf4ad5f89 => 27
	i32 4151237749 ; 55: System.Core => 0xf76edc75 => 6
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [56 x i32] [
	i32 23, i32 5, i32 2, i32 11, i32 9, i32 17, i32 22, i32 16, ; 0..7
	i32 4, i32 7, i32 14, i32 26, i32 23, i32 5, i32 17, i32 21, ; 8..15
	i32 12, i32 19, i32 7, i32 15, i32 21, i32 25, i32 20, i32 8, ; 16..23
	i32 6, i32 16, i32 20, i32 22, i32 19, i32 18, i32 8, i32 0, ; 24..31
	i32 1, i32 0, i32 2, i32 11, i32 10, i32 4, i32 15, i32 25, ; 32..39
	i32 24, i32 27, i32 14, i32 24, i32 13, i32 1, i32 10, i32 3, ; 40..47
	i32 26, i32 18, i32 3, i32 9, i32 13, i32 12, i32 27, i32 6 ; 56..55
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
