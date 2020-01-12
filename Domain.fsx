type BlobId = BlobId

type Blob = 
    { Id : BlobId }

type RemoteStore = RemoteStore

type LocalStore = LocalStore

type ListBlobs = LocalStore -> Blob Set

type Compare = LocalStore -> RemoteStore -> Blob Set

type ErrorMessage = ErrorMessage of string

type RemoteBackup = RemoteStore -> Blob Set -> Result<BlobId, BlobId * ErrorMessage> list

