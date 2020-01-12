//info :https://cloud.google.com/resource-manager/reference/rest/v1/projects/list
//sample : https://cloud.google.com/resource-manager/docs/creating-managing-projects

let rawHttpProject = """POST https://cloudresourcemanager.googleapis.com/v1/projects/
Authorization: *************
Content-Type: application/json

{
    "projectId": "our-project-123",
    "name": "my project",
    "labels": {
      "mylabel": "prod"
    }
}"""