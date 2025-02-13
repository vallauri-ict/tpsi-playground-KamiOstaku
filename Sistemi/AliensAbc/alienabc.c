#include <assert.h>
#include <stdio.h>
#include <stdlib.h>

// constraints
#define MAXL 100

// input data
int T;
char S[MAXL];

int main()
{
	// uncomment the following lines if you want to read/write from files
	// freopen("input.txt", "r", stdin);
	// freopen("output.txt", "w", stdout);

	int cont,i;

	assert(1 == scanf("%d", &T));
	for (int i = 0; i < T; i++)
	{
		assert(1 == scanf("%s", S));

		i = 0;
		while (i < strlen(S)-1)
		{
			if(S[i] == S[i + 1])
			{
				printf("%c%c ", S[i],S[i]);
			}
			else
			{
				printf("%c ", S[i]);
			}
			i++;
		}
	}

		return 0;
}
