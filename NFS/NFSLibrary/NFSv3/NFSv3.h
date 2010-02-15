/*
 * NekoDrive
 * 2010 by Mirko Gatto
 * mirko.gatto@gmail.com
 *
 * NFS V3 Wrapper
 *
 * Users may use, copy or modify this library 
 * according GNU General Public License v3 (http://www.gnu.org/licenses/gpl.html)
 */

#ifndef __IncNFSV3h
#define __IncNFSV3h

#pragma pack(1) 

#ifdef NFSV3_EXPORTS
#define NFSV3_API __declspec(dllexport)
#else
#define NFSV3_API __declspec(dllimport)
#endif

#include <iostream>
#include <vector>
#include <string>
#include <rpc/rpc.h>
#include "NFSv3MountProtocol.h"

#define MAX_HOST_NAME 255
#define MAX_FILE_NAME 255
#define NFS_SUCCESS 0
#define NFS_ERROR -1

struct NFSData
{
	unsigned long DateTime;
	unsigned int Type;
	unsigned int Size;
	unsigned int Blocks;
	unsigned int BlockSize;
	fhandle3 Handle;
};


struct StringVector
{
	std::vector<std::string> Str;
};


class NFSV3_API CNFSv3
{
private:
	unsigned int uiServer;
	std::string strServer;
	CLIENT* clntMountV3;
	CLIENT* clntV3;
	SOCKET sSocket;
	struct sockaddr_in sSrvAddr;
	struct timeval timeOut;
	std::string strCurrentDevice;
	std::string strLastError;
	fhandle3 nfsCurrentDirectory;
	fhandle3 nfsCurrentFile;
	int authType;
	int uid;
	int gid;
	void InitStructure(NFSData* pNfsData);
	int CheckOpenHandle();
	int CreateAuthentication();
public:
	StringVector v;
	CNFSv3();
	~CNFSv3();
	int Connect(unsigned int ServerAddress, int UserId, int GroupId);
	int Disconnect();
	char** GetExportedDevices(int* pnSize);
	char** GetItemsList(int* pnSize);
	void ReleaseBuffers(void** pBuffers);
	void ReleaseBuffer(void* pBuffer);
	int MountDevice(char* pDevice);
	int UnMountDevice();
	void* GetItemAttributes(char* pName);
	int ChangeCurrentDirectory(char* pName);
	int CreateDirectory(char* pName);
	int DeleteDirectory(char* pName);
	int DeleteFile(char* pName);
	int CreateFile(char* pName);
	int Open(char* pName);
	void CloseFile();
	int Read(u_int Offset, u_int Count, char* pBuffer, u_long* pSize);
	int Write(u_int Offset, u_int Count, char* pBuffer, u_long* pSize);
	int Rename(char* pOldName, char* pNewName);
	const char* GetLastNfsError();
	int ChangeMode(char* pName, int Mode);
	int ChangeOwner(char* pName, int UID, int GUID);
};

NFSV3_API CNFSv3* CreateCNFSv3();

NFSV3_API void DisposeCNFSv3(CNFSv3* pObject);

#endif