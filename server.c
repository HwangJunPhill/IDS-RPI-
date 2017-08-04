#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include <sys/stat.h>
#include <arpa/inet.h>



#define MAXBUF 1024
int main(int argc, char **argv)
{
	int server_sockfd, client_sockfd;
	int client_len, n;
	char buf[MAXBUF];
	struct sockaddr_in clientaddr, serveraddr;

	client_len = sizeof(clientaddr);
	if (argc < 2)
	{
		printf("Help : server port no");
		return 1;
	}

	if((server_sockfd = socket(AF_INET, SOCK_STREAM, 0 )) == -1)
	{
		perror("socket error : ");
		exit(0);
	}

	memset(&serveraddr, 0, sizeof(serveraddr));
	serveraddr.sin_family = AF_INET;
	serveraddr.sin_addr.s_addr = htonl(INADDR_ANY);
	serveraddr.sin_port = htons(atoi(argv[1]));

	bind(server_sockfd, (struct sockaddr *)&serveraddr, sizeof(serveraddr));

	listen(server_sockfd, 5);

	memset(buf, 0x00, MAXBUF);
	client_sockfd = accept(server_sockfd, (struct sockaddr *)&clientaddr, &client_len);

	printf("New Client Connect : %s\n", inet_ntoa(clientaddr.sin_addr));
	while(1)
	{
		if ((n = recv(client_sockfd, buf, MAXBUF, 0)) <= 0)
		{
			close(client_sockfd);
			break;
		}

	        int i = 0;
                for(i = 0; i < 24; i++)
                {
	                printf("%x ", buf[i]);
                }
                puts("");

	}
	close(server_sockfd);
	return 0;
}
