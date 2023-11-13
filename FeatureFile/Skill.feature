Feature: Feature1

A short summary of the feature

	@AddFeatureOfSkill
Scenario: [Adding skills with valid inputs]
	Given [	I log in to the Mars page succesfully]
	And [I navigate to skill page ]
	When [I add new skills '<Skill>' '<level>']
	Then [Skill should be added succesfully '<Skill>' '<level>' '<message> ]
	Examples:
	| Skill    |  | Level        | Message                 |
	| Business |  | Expert       | Bsuiness has been added |
	| Cooking  |  | Intermediate | Cooking has been added  |

	@addingskillwithInvalidInputs
Scenario: [adding skill with duplicate data]
	Given [	I log in to the Mars page succesfully]
	And [I navigate to skill page ]
	When [I add skills with same language but different level '<Skill>' '<level>']
	Then [gives error message '<duplicatedata>' ]
	Examples:
	| Skill    |  | Level        | Message        |
	| Business |  | Beginner     | Duplicate Data |

	@cancelandeditfunction@skill
Scenario: [edit and cancel function]
	Given [	I log in to the Mars page succesfully]
	And [I navigate to skill page ]
	When [Click on edit button and cancel button]
	Then [record should be edit and cancel  ]
	
	