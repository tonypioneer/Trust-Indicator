# Trust-Indicator
## Table of Contents
1. [Project Description](#project-description)
2. [Team Members and Roles](#team-members-and-roles)
3. [Statement of Work](#statement-of-work)
4. [Getting Start](#getting-start)
5. [Project Management](#project-management)
6. [Team Charter](#team-charter)
7. [Meeting Minutes](#meeting-minutes)
8. [Decision Logs](#decision-logs)
9. [Conflict Resolution Protocol](#conflict-resolution-protocol)
10. [Testing Summary](#testing-summary)
11. [User Manual](#user-manual)
12. [Deliverables](#deliverables)
13. [Future Improvements](#future-improvements)
14. [Risk Management](#risk-management)
15. [Acknowledgements](#acknowledgements)
## Project Description
- **Version:** 1.0.0, August, 2023
  
- **Developers:** COMP8715 Computing Project, Australian National University, Australia
  
- **Background:** With the widespread use of social media and online digital media, the authenticity of photos and creative images has become a global concern. In this digital age, the extensive dissemination of images and advanced editing techniques make it difficult for ordinary users and consumers to discern the authenticity and credibility of images. Misleading, manipulated, or artificially generated images can lead to inaccurate and confusing information dissemination.
  
- **Objective:** The project aims to develop a photo repository website with Australia as its theme, aiding consumers in better understanding and evaluating the credibility of images by displaying uploaded image metadata and providing visual cues. The website will be an open-source project, allowing users to upload their own images while adhering to knowledge-sharing (CC) license requirements. By collecting image metadata and displaying credibility signals, the website will assist users in identifying and discerning authentic images. Additionally, website members can contribute contextual information, such as photographer statements, to provide more background details.
The project's objective is to offer consumers a reliable resource to improve their ability to judge image authenticity. It also provides photographers and creators with a platform to showcase their works and offer additional information, enhancing public understanding and awareness of images. By being an open-source project, the website encourages other developers to contribute and improve, facilitating ongoing project development and enhancement.

- **Tech Stack:** [Tech Stack Documentation](docs/Tech%20Stack/README.md)
  
- **Stakeholders:** [Stakerholders analysis](docs/Stakeholders%20List%20and%20Impact/README.md)

## Team Members and Roles
|UID|Name|Role|
|:---------|:------------:|:-------------------------------------:|
|u7588748|Lingxiu Cai|Frontend & Backend Developer|
|u7504537|Tony Chen|Project Manager & CTO|
|u7529732|Song Han|Frontend & DataBase Manager|
|u7531066|Vidhu Chaudhary|Documentation Manager & Frontend Developer|
|u7342064|Yifang Meng|Backend & Quality Assurance|
|u7545864|Zhaoyun Zhang|Backend & Machine Learning Instructor|
## Statement of Work
[Statement of Work](docs/Statement of Work/(updated) Trust Indicators - Statement of Work.pdf)

## Getting Start
See the [online documentation](docs/Reference/) for references we referenced in the project.

We use [GitHub Discussions](https://github.com/YifangMeng/Trust-Indicator/discussions) as our forum, and Microsoft Teams for chat. These are great places to ask questions and advice from the community or to discuss projects.

For bugs and feature requests, please [raise an issue](https://github.com/YifangMeng/Trust-Indicator/issues/new/choose) and follow the templates there.

#### Installation

Trust-Indicator is designed to function primarily as an online tool. The development team is in the process of deploying the tool to a server, which, once complete, can be accessed through the following link: [image.com.au]().

In addition, Trust-Indicator is open to personal adaptions or updates. Below are the instructions for setting up locally:

**Step 1:** Installing the necessary dependencies.

Visual Studio, C# .NET 6 and Microsoft Entity Framework.

[Visual Studio 2022 download](https://visualstudio.microsoft.com/downloads/)
During this process, you can click on the .NET core to install .NET

**Step 2:** Clone the repository to your machine.

**Step 3:** Find the sln file in the directory `Trust-Indicator/src/backend/Trust-Indicator/Trust-Indicator.sln`, open it and it will automatically set up the project with Visual Studio. 

**Step 4:** Press `run` in Visual Studio and run `index.html` in the directory `Trust-Indicator/src/frontend/index.html`.

## Project Management
In managing our web API development project, we faced challenges such as increasing complexity, the need for consistency in development environments, version control requirements, and time and resource constraints. To address these, we made the following decisions:

- Use Git as our version control system to facilitate collaboration and prevent conflicts.
- Utilize development environments like Visual Studio and WebStorm to ensure uniformity across the team and prevent inconsistencies.
- Use Postman for testing to ensure the code's reliability and effectiveness.
- Chose GitHub Projects for [task management](https://github.com/tonypioneer/Trust-Indicator/issues), the GitHub [Kanban workflow](https://github.com/users/tonypioneer/projects/1/views/1), and the GitHub [timeline](https://github.com/users/tonypioneer/projects/1/views/9) for our development process, aiming for seamless integration, simplicity, cost-effectiveness, and enhanced collaboration within the team.
- Organize weekly catch-up meetings for code review before merging into the main branch to maintain code quality, ensuring that the code is readable, maintainable, efficient, and error-free.

By focusing on integration, simplicity, and collaboration, we've positioned our team to work with greater agility and transparency, aligning our tooling and workflows with the specific needs and goals of our project. The full decision log can be accessed [here](docs/Decision%20Logs/Tools%20for%20Project%20Management.md).


## Team Charter
This [document](docs/Team%20Charter/Team%20Charter.md) elaborates on the team's goals, structure, duties, norms, and protocols. It sets a clear direction and delineation for the team, aiding members in fostering mutual expectations and consensus. The primary aim of the team charter is to enhance team efficiency, bolster collaboration, and reduce misunderstandings and potential conflicts.

## Meeting Minutes
- [Client Meeting](docs/Meeting%20Minutes/Client%20Meeting/)
- [Team Meeting](docs/Meeting%20Minutes/Team%20Meeting/)
- [Tutorial Meeting](docs/Meeting%20Minutes/Tutorial%20Meeting/)
## Decision Logs
The Decision Log System is a tool designed to track and manage decisions made within a project or organization. By logging decisions, including the context, rationale, options considered, and outcomes, teams can improve transparency, responsibility, and learning. This [Decision Logs](docs/Decision%20Logs/) of our project documentation serves as a comprehensive record of all the key decisions made throughout the project lifecycle. 

## Conflict Resolution Protocol
- **Purpose:**
<p>The purpose of this document is to outline a well-defined protocol for handling conflicts within our Android development team. This protocol is intended to ensure that disagreements and issues are resolved efficiently and effectively, allowing us to maintain a healthy and collaborative work environment while focusing on the completion of our APP design and testing tasks.</p>

- **Protocol:**
  - **Identifying the Conflict:**
    <p>Team members should openly and respectfully communicate any concerns or disagreements that arise during the course of the project. This may be done in-person, through 
    video calls, or other appropriate communication channels.
    Conflicts should be brought up as soon as possible to prevent escalation and to ensure timely resolution.</p>
  - **Open Discussion:**
    <p>Once a conflict has been identified, all parties involved should engage in an open discussion to better understand the root cause of the issue.</p>
    <p>Each team member involved should have the opportunity to express their perspective and concerns without interruption.
    Have group meeting twice a week on Wednesday(on-campus) and Sunday(on-line).</p >
    <p>Active listening should be practiced by all participants, ensuring that everyone's viewpoint is heard and understood.</p>
  - **Brainstorming Solutions:**
    <p>After all parties have had a chance to express their concerns, the group should brainstorm potential solutions to the conflict.</p>
    <p>Team members are encouraged to offer suggestions and ideas, no matter how unconventional they may seem.</p>
    <p>The team should aim for a consensus-based solution, where all parties involved are in agreement.</p>
## Testing Summary
In the [testing report](docs/Testing%20Summary), we will highlight the key testing milestones, the test strategies employed, and the outcomes of our testing activities to ensure the quality and reliability of our Product/Software/Service.
## User Manual
Welcome to our product! In this [user manual]() (we will update this document when the product is delivered), you will find detailed guides and instructions on how to use our product. Whether you are a beginner or an experienced user, this manual will help you get started quickly and unleash the full potential of the product. 

## Deliverables

The project mainly has the following deliverables.

### Top Priorities

- Website Prototype: Initial design and functionality.
- Domain Name Recommendation Report: A list of suggested domain names.
- Server Environment Setup Documentation: Instructions on how to set up the server.
- Image Metadata Extraction Tool: A tool or feature that extracts and records details like shooting equipment, date, geographic location, etc.
- Credibility Signal Design Research Report: Recommendations on credibility signal design based on image metadata.
- EXIF Information Viewing Feature: A feature allowing users to view EXIF details of uploaded images.
- Image Upload Feature: Interface and backend functionality for users to upload images.
- Contextual Information Addition Feature: Allows users to add photographer statements or other relevant details to images.
- Image Collection Feature: Allows users to create collections and save their favorite images.
- Image Tag and Keyword Management Feature: Users can add and manage tags and keywords for images.
- Data Backup Mechanism: Ensures the safety and integrity of images and metadata.
- Comment and Rating Feature: Allows users to leave comments and ratings on image pages.
  
### Intermediate Priorities - If Applicable
- Knowledge Sharing License Embedding Feature: Displays copyright information for uploaded images and content on the website.
- Image Credibility Signals/Visual Cues Feature: Helps users assess the credibility of images.
- Accuracy and Credibility Verification Mechanism for Added Contextual Information: Ensures the accuracy and credibility of added contextual details.
- Image Search Feature: Allows users to search based on keywords, date ranges, geographical locations, and other metadata.
- Image Filtering Feature: Enables users to filter image results based on credibility, license types, and other criteria.
- Image Sharing Feature: Allows users to share their favorite images on social media or via links.
- User Feedback System: Enables users to provide feedback, suggestions, or report issues to website administrators.
- Security Measures Documentation: Describes how to prevent malicious uploads or data breaches.


## Future Improvements
Considering future improvements and continuous optimization is crucial when developing a project. While our goal is to deliver a high-quality product at the current stage, we recognize that technology and market conditions are constantly changing. Therefore, we are willing to invest time and effort in thinking and planning for future enhancements.

In the initial phase of project development, our focus is on implementing core features and meeting basic requirements. However, we also understand that this is just the beginning, and we look forward to continuing to improve and refine the product after delivery.

Our team will also maintain an open and flexible attitude. As the project progresses, we are ready to make adjustments and optimizations based on real-world conditions. We deeply understand that project development is an ongoing iterative process, not a one-time task.

In the [future work document](docs/Future%20Improvements), we have listed a continuous feature roadmap for accomplishing future objectives. These functionalities represent our team's vision and mission, serving as the guiding direction and goals for our progress.

  
During the implementation of these features, we will also prioritize team cohesion and effective communication. We will actively explore new solutions and ideas, conducting experiments and testing to ensure the stability and reliability of the functionalities. Additionally, we will focus on enhancing the user experience to ensure our product truly meets the needs of our users.

## Risk Management
[Risk management](docs/Risk%20management/Risk%20management.md) explores how to effectively identify, analyze, and address these risks, ensuring that our software products are of high quality, delivered on time, and within budget.

## Acknowledgements
We would like to express our gratitude to all those who helped us during the completion of this project.

My deepest gratitude goes first and foremost to the teaching team (Elena Williams & Charles Gretton) and client (Sabrina Caldwell). The teacher team provides a platform for us to communicate with customers in a timely manner and provide feedback and help with our requirements. Meanwhile, clients who play a vital role in the design of the project put forward a lot of instructive advice and useful suggestions for us.

We are also deeply indebted to those who use our web app and fill out the questionnaire. It was because of the bugs they found and the constructive comments they provided that the project came to a successful end.

Contact us EMAIL:  Please feel free to contact us (u7342064@anu.edu.au) if you have any questions.
