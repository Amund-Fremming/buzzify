import {  } from "@/contenttypes";


export const getById = async (id: number) => {
	try {
		const response = await fetch(`api/User/${id}}`, {
			method: "GET",
			headers: {
				"Content-Type": "application/json",
				
			},
			
		});

		if (!response.ok) {
			const errorMessage = await response.json();
			throw new Error(errorMessage);
		}

		
	} catch (error) {
		console.log("GetById -", error);
	}
};

export const getAll = async () => {
	try {
		const response = await fetch(`api/User/all}`, {
			method: "GET",
			headers: {
				"Content-Type": "application/json",
				
			},
			
		});

		if (!response.ok) {
			const errorMessage = await response.json();
			throw new Error(errorMessage);
		}

		
	} catch (error) {
		console.log("GetAll -", error);
	}
};
