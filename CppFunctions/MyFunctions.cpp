#define MyFunctions _declspec(dllexport)

struct MyStruct {
	int a;
	int b;
};

extern "C" {
	MyFunctions int AddNumbers(int a, int b) {
		return a + b;
	}

	MyFunctions int SubtractNumbers(int a, int b) {
		return a - b;
	}
}
