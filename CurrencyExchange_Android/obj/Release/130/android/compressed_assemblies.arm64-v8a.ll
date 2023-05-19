; ModuleID = 'obj\Release\130\android\compressed_assemblies.arm64-v8a.ll'
source_filename = "obj\Release\130\android\compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [134656 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [165888 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [300032 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [1134592 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [121856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [690176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [1073664 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [747008 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [218112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [38912 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [65024 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [1318912 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [844288 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [318464 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [142336 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [8704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [40960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [152576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [14848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [15872 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [36352 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [12800 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [26112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [18072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [2111488 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [28 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 134656, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([134656 x i8], [134656 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 165888, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([165888 x i8], [165888 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 300032, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([300032 x i8], [300032 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 1134592, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1134592 x i8], [1134592 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 121856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([121856 x i8], [121856 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 690176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([690176 x i8], [690176 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 1073664, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1073664 x i8], [1073664 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 747008, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([747008 x i8], [747008 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 218112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218112 x i8], [218112 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 38912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([38912 x i8], [38912 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 65024, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([65024 x i8], [65024 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 1318912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1318912 x i8], [1318912 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 844288, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([844288 x i8], [844288 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 318464, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([318464 x i8], [318464 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 142336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([142336 x i8], [142336 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 8704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8704 x i8], [8704 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 40960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([40960 x i8], [40960 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 152576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([152576 x i8], [152576 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14848 x i8], [14848 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 15872, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15872 x i8], [15872 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 36352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36352 x i8], [36352 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 12800, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([12800 x i8], [12800 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26112 x i8], [26112 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 18072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18072 x i8], [18072 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 2111488, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2111488 x i8], [2111488 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}
], align 8; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 28, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([28 x %struct.CompressedAssemblyDescriptor], [28 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 8


!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
