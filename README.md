# Capstone Project For Udacity Cloud DevOps Nanodegree

<h3 align="center">Continuous deployment pipeline to deploy ASP.NET Core Application to AWS EKS cluster using CircleCI</h3>
<p align="center">This is a CI/CD pipeline using CircleCI that automatically deploy ASP.NET Core Application to EKS Cluster.</p>

<p align="center">
  <a href="https://circleci.com/gh/vuongvx96/AWS_Cloud_DevOps_Capstone">
    <img src="https://img.shields.io/circleci/build/github/vuongvx96/AWS_Cloud_DevOps_Capstone" />
  </a>
  <a href="https://sonarcloud.io/summary/new_code?id=vuongvx96_AWS_Cloud_DevOps_Capstone">
    <img src="https://sonarcloud.io/api/project_badges/measure?project=vuongvx96_AWS_Cloud_DevOps_Capstone&metric=alert_status" />
  </a>
  <a href="https://dotnet.microsoft.com/en-us/download/dotnet/6.0">
    <img src="https://img.shields.io/badge/dotnet%20version-net6.0-blue" />
  </a>
  <a href="https://github.com/vuongvx96/AWS_Cloud_DevOps_Capstone/pulls">
    <img src="https://img.shields.io/badge/PRs-Welcome-brightgreen.svg?style=flat-square" />
  </a>
</p>

## Project Tasks

---
The project's goal is to apply the skills and knowledge that I developed throughout the Cloud DevOps Nanodegree program. In this project I did:

* Working in AWS
* Using CircleCI to implement Continuos Integration and Continuos Deployment
* Building pipelines
* Working with Ansible and CloudFormation to deploy clusters
* Building Kubernetes clusters
* Building Docker containers in pipelines

## Tech Stack

---
| Technology | Description                                                                           | Link ↘️                 |
| ---------- | ------------------------------------------------------------------------------------- | ----------------------- |
| AWS        | Online platform that provides scalable and cost-effective cloud computing solutions   | <https://aws.amazon.com//>      |
| C#         | High Level, Mutli-paradigm, Compiled Language                                         | <https://docs.microsoft.com/en-us/dotnet/csharp/> |
| .NET 6.0   | The merger of .NET Framework and .NET Core, Open source, Cross platform | <https://docs.microsoft.com/en-us/dotnet/>  |
| Docker     |  Open platform for developing, shipping, and running applications | <https://docs.docker.com/> |
| Kubernetes | Open-source system for automating deployment, scaling, and management of containerized applications | <https://kubernetes.io/>    |
| Ansible    | IT automation tool that automates cloud provisioning configuration management, application deployment, infra-service orchestration and many other IT needs                                                          | <https://www.ansible.com/>      |
| CircleCI    | Continuos integration & delivery platform that helps the development teams to release code rapidly and automate the build, test, and deploy               | <https://circleci.com/>      |

## Requirements

1. Create the CircleCI account
2. Create a Github repository
3. Set up a Dockerhub account and repository
4. Create an AWS - IAM user with the policies suggested on the official eksctl website as [Minimum IAM policies](https://eksctl.io/usage/minimum-iam-policies/)
